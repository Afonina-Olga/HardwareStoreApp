using HardwareStoreApp.Models;
using HardwareStoreApp.Repositories;
using System;
using System.Windows.Forms;

namespace HardwareStoreApp
{
	public partial class BalanceForm : Form
	{
		private readonly IProductRepository _productRepository;
		private readonly IStoreRepository _storeRepository;
		private readonly IBalanceRepository _balanceRepository;

		public BalanceForm(
			IProductRepository productRepository,
			IStoreRepository storeRepository,
			IBalanceRepository balanceRepository)
		{
			_productRepository = productRepository;
			_storeRepository = storeRepository;
			_balanceRepository = balanceRepository;
			InitializeComponent();
		}

		private async void BtnAdd_Click(object sender, EventArgs e)
		{
			var countValue = txtCount.Text.Trim();
			var priceValue = txtPrice.Text.Trim();
			var product = (Product)cbProduct.SelectedItem;
			var store = (Store)cbStore.SelectedItem;

			if (string.IsNullOrEmpty(countValue) || string.IsNullOrEmpty(priceValue))
			{
				MessageBox.Show("Не все поля заполнены");
				return;
			}

			if (!int.TryParse(countValue, out _) || !decimal.TryParse(priceValue, out _))
			{
				MessageBox.Show("Ввод некорректен");
				return;
			}

			var price = decimal.Parse(priceValue);
			var count = int.Parse(countValue);

			try
			{
				var balance = await _balanceRepository.Get(product.Id, store.Id, price);
				if (balance != null)
				{
					// Update найденного
					balance.Count += count;
					await _balanceRepository.Update(balance.Id, balance);
				}
				else
				{
					// Создание нового 
					await _balanceRepository.Create(new Balance()
					{
						Count = count,
						Price = price,
						Product = product,
						Store = store
					});
				}

				MessageBox.Show("Успешно");
			}
			catch
			{
				MessageBox.Show("Что-то пошло не так...");
			}
		}

		private async void RefreshProducts()
		{
			var products = await _productRepository.Get();
			bsProduct.DataSource = products;

			bsProduct.ResetBindings(false);
			cbProduct.DataSource = bsProduct;
			cbProduct.ValueMember = "Name";
			cbProduct.SelectedIndex = 0;
		}

		private async void RefreshStores()
		{
			var stores = await _storeRepository.Get();
			bsStore.DataSource = stores;

			bsStore.ResetBindings(false);
			cbStore.DataSource = bsStore;
			cbStore.ValueMember = "Name";
			cbStore.SelectedIndex = 0;
		}

		private void BalanceForm_Load(object sender, EventArgs e)
		{
			RefreshStores();
			RefreshProducts();
		}
	}
}

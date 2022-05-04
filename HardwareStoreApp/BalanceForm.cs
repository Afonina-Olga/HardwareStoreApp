using HardwareStoreApp.Models;
using HardwareStoreApp.Repositories;
using System;
using System.Linq;
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

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			var count = txtCount.Text.Trim();
			var price = txtPrice.Text.Trim();

			if (string.IsNullOrEmpty(count) || string.IsNullOrEmpty(price))
			{
				MessageBox.Show("Не все поля заполнены");
				return;
			}

			if (!int.TryParse(count, out _) || !decimal.TryParse(price, out _))
			{
				MessageBox.Show("Ввод некорректен");
				return;
			}
			
			try
			{
				var result = _balanceRepository.Create(new Balance()
				{
					Count = int.Parse(count),
					Price = decimal.Parse(price),
					Product = (Product)cbProduct.SelectedItem,
					Store = (Store)cbStore.SelectedItem
				});
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

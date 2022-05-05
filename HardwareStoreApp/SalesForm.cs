using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using HardwareStoreApp.Models;
using HardwareStoreApp.Repositories;
using HardwareStoreApp.Services;

namespace HardwareStoreApp
{
	public partial class SalesForm : Form
	{
		private readonly IProductRepository _productRepository;
		private readonly IStoreRepository _storeRepository;
		private readonly IBalanceRepository _balanceRepository;
		private readonly IAccountingService _accountingService;

		public SalesForm(
			IProductRepository productRepository,
			IStoreRepository storeRepository,
			IBalanceRepository balanceRepository,
			IAccountingService accountingService)
		{
			_productRepository = productRepository;
			_storeRepository = storeRepository;
			_balanceRepository = balanceRepository;
			_accountingService = accountingService;
			InitializeComponent();
		}

		private async void BtnCreate_Click(object sender, EventArgs e)
		{
			var countValue = txtSaleCount.Text.Trim();
			var balance = int.Parse(txtBalance.Text.Trim());
			var price = int.Parse(txtPrice.Text.Trim());
			var product = (Product)cbProduct.SelectedItem;
			var store = (Store)cbStore.SelectedItem;
			var date = dtSaleDate.Value;

			if (string.IsNullOrEmpty(countValue))
			{
				MessageBox.Show("Не все поля заполнены");
				return;
			}

			if (!int.TryParse(countValue, out _))
			{
				MessageBox.Show("Ввод некорректен");
				return;
			}

			var count = int.Parse(countValue);
			if (count > balance)
			{
				MessageBox.Show("Недостаточно товара");
				txtSaleCount.Text = txtBalance.Text;
				return;
			}

			var result = await _accountingService.RegisterSale(product.Id, store.Id, date, price, count);

			if (result)
				MessageBox.Show("Продажа зарегистрирована");

			RefreshData();
			await SetBalanceAndCount(product.Id, store.Id);
		}

		private void SalesForm_Load(object sender, EventArgs e)
		{
			RefreshData();
		}

		private async void CbProduct_SelectedIndexChanged(object sender, EventArgs e)
		{
			var combo = sender as ComboBox;
			if (combo.SelectedItem != null && cbStore.SelectedItem != null)
				await SetBalanceAndCount(((Product)combo.SelectedItem).Id, ((Store)cbStore.SelectedItem).Id);
		}

		private async void RefreshData()
		{
			var balances = await _balanceRepository.Get(true);
			FormHelper.RefreshComboboxDataSource(balances.Select(_ => _.Store).Distinct(), bsStore, cbStore, "Name", true);
			FormHelper.RefreshComboboxDataSource(balances.Select(_ => _.Product).Distinct(), bsProduct, cbProduct, "Name", true);
		}

		private async void CbStore_SelectedIndexChanged(object sender, EventArgs e)
		{
			var combo = sender as ComboBox;
			if (combo.SelectedItem != null && cbProduct.SelectedItem != null)
				await SetBalanceAndCount(((Product)cbProduct.SelectedItem).Id, ((Store)combo.SelectedItem).Id);
		}

		private async Task SetBalanceAndCount(int productId, int storeId)
		{
			var result = await _balanceRepository.Get(productId, storeId, true);
			txtBalance.Text = result != null ? result.Count.ToString() : "0";
			txtPrice.Text = result != null ? result.Price.ToString("0.##") : "0.00";
		}

		private void TxtBalance_TextChanged(object sender, EventArgs e)
		{
			SetEnable();
		}

		private void TxtPrice_TextChanged(object sender, EventArgs e)
		{
			SetEnable();
		}

		private void SetEnable()
		{
			var price = txtPrice.Text;
			var count = txtBalance.Text;
			btnCreate.Enabled =
				!string.IsNullOrEmpty(price) &&
				price != "0.00" &&
				!string.IsNullOrEmpty(count) &&
				count != "0";
		}
	}
}

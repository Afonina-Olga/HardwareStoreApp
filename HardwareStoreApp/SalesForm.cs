﻿using System;
using System.Threading.Tasks;
using System.Windows.Forms;

using HardwareStoreApp.Models;
using HardwareStoreApp.Repositories;

namespace HardwareStoreApp
{
	public partial class SalesForm : BaseForm
	{
		private readonly IProductRepository _productRepository;
		private readonly IStoreRepository _storeRepository;
		private readonly IBalanceRepository _balanceRepository;

		public SalesForm(
			IProductRepository productRepository,
			IStoreRepository storeRepository,
			IBalanceRepository balanceRepository)
		{
			_productRepository = productRepository;
			_storeRepository = storeRepository;
			_balanceRepository = balanceRepository;
			InitializeComponent();
		}

		private async void BtnCreate_Click(object sender, EventArgs e)
		{
			var countValue = txtSaleCount.Text.Trim();
			var balance = int.Parse(txtBalance.Text.Trim());
			var product = (Product)cbProduct.SelectedItem;
			var store = (Store)cbStore.SelectedItem;

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
			
			var result = await _balanceRepository.Get(product.Id, store.Id);
		}

		private async void SalesForm_Load(object sender, EventArgs e)
		{
			var stores = await _storeRepository.Get();
			var products = await _productRepository.Get();
			RefreshComboboxDataSource(stores, "Name", bsStore, cbStore);
			RefreshComboboxDataSource(products, "Name", bsProduct, cbProduct);
		}

		private async void CbProduct_SelectedIndexChanged(object sender, EventArgs e)
		{
			var combo = sender as ComboBox;
			if (combo.SelectedItem != null && cbStore.SelectedItem != null)
				await SetBalanceAndCount(((Product)combo.SelectedItem).Id, ((Store)cbStore.SelectedItem).Id);
		}

		private async void CbStore_SelectedIndexChanged(object sender, EventArgs e)
		{
			var combo = sender as ComboBox;
			if (combo.SelectedItem != null && cbProduct.SelectedItem != null)
				await SetBalanceAndCount(((Product)cbProduct.SelectedItem).Id, ((Store)combo.SelectedItem).Id);
		}

		private async Task SetBalanceAndCount(int productId, int storeId)
		{
			var result = await _balanceRepository.Get(productId, storeId);
			txtBalance.Text = result != null ? result.Count.ToString() : "0";
			txtPrice.Text = result != null ? result.Price.ToString("0.##") : "0.00";
		}

		private void TxtBalance_TextChanged(object sender, EventArgs e)
		{
			var text = (sender as TextBox).Text;
			btnCreate.Enabled = !string.IsNullOrEmpty(text) && text != "0";
		}

		private void TxtPrice_TextChanged(object sender, EventArgs e)
		{
			var text = (sender as TextBox).Text;
			btnCreate.Enabled = !string.IsNullOrEmpty(text) && text == "0.00";
		}
	}
}

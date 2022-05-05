using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

using HardwareStoreApp.Models;
using HardwareStoreApp.Services;
using HardwareStoreApp.Stores;
using HardwareStoreApp.Repositories;
using System.Linq;
using HardwareStoreApp.ViewModels;
using System.Collections.Generic;

namespace HardwareStoreApp
{
	// Использование внедрения зависимостей в WinForms
	//https://stackoverflow.com/questions/70475830/how-to-use-dependency-injection-in-winforms
	public partial class MainForm : Form
	{
		private readonly IAuthenticationService _authenticationService;
		private readonly IUserStore _userStore;
		private readonly IProductService _productService;

		public MainForm(
			IAuthenticationService authenticationService,
			IUserStore userStore,
			IProductService productService)
		{
			_authenticationService = authenticationService;
			_userStore = userStore;
			_productService = productService;
			InitializeComponent();
		}

		private async void MainForm_Load(object sender, EventArgs e)
		{
			_userStore.UserChanged += OnUserChanged;
			adminMenuItem.Visible = false;
			reportMenuItem.Visible = false;
			await _authenticationService.Register("Admin", "123", Role.Admin);

			var products = await _productService.GetAll();
			RefreshGrid(products);

			var categories = await _productService.GetCategories();
			RefreshCombobox(categories, bsCategory, cbCategory);

			var regions = await _productService.GetRegions();
			RefreshCombobox(regions, bsRegions, cbRegion);
		}

		private void SetColumns(string[] names)
		{
			for (int i = 0; i < names.Length; i++)
				FormHelper.SetColumnSettings(productGrid.Columns[i], names[i]);
		}

		private void RefreshCombobox(string[] items, BindingSource source, ComboBox comboBox)
		{
			if (items.Any())
			{
				source.DataSource = items.Distinct();
				source.ResetBindings(false);
				comboBox.DataSource = source;
				comboBox.SelectedIndex = -1;
			}
		}

		private void OnUserChanged()
		{
			loginMenuItem.Text = _userStore.IsSignedIn ? "Выход" : "Вход";
			adminMenuItem.Visible = _userStore.Role == Role.Admin;
			reportMenuItem.Visible = _userStore.Login != null;
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			_userStore.UserChanged -= OnUserChanged;
		}

		private void LoginMenuItem_Click(object sender, EventArgs e)
		{
			if (_userStore.IsSignedIn)
			{
				_userStore.SignOut();
			}
			else
			{
				ShowDialog<LoginForm>();
			}
		}

		private void ManageUsersMenuItem_Click(object sender, EventArgs e)
		{
			ShowDialog<ManageUserAccountsForm>();
		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FillDatabaseMenuItem_Click(object sender, EventArgs e)
		{
			ShowDialog<CreateProductsAndStoresForm>();
		}

		private void ShowDialog<T>()
			where T : Form
		{
			var form = Program.Services.GetRequiredService<T>();
			form.ShowDialog();
		}

		private void RefreshGrid(IEnumerable<Balance> items)
		{
			if (items.Any())
			{
				bsProduct.DataSource = items.Select(_ => new ProductViewModel()
				{
					Name = _.Product.Name,
					Category = _.Product.Category.Name,
					Price = _.Price,
					Count = _.Count,
					StoreName = _.Store.Name,
					DistrictName = _.Store.Address.Region
				});

				bsProduct.ResetBindings(false);
				productGrid.DataSource = bsProduct;

				SetColumns(new string[] {
				"Название товара",
				"Категория" ,
				"Название магазина" ,
				"Район" ,
				"Количество" ,
				"Цена" });
			}
			else
				bsProduct.DataSource = null;
		}

		private void AddProductsMenuItem_Click(object sender, EventArgs e)
		{
			ShowDialog<BalanceForm>();
		}

		private void SalesMenuItem_Click(object sender, EventArgs e)
		{
			ShowDialog<SalesForm>();
		}

		private async void BtnApply_Click(object sender, EventArgs e)
		{
			var region = cbRegion.Text;
			var store = cbStore.Text;
			var name = txtName.Text.Trim();
			var isExact = cbExact.Checked;
			var category = cbCategory.Text;
			var priceFilter = cbMinPrice.Checked;
			var fullSearch = cbFullSearch.Checked;

			var result = await _productService.Find(region, store, name, category, fullSearch);

			if (isExact)
				result = result.Where(_ => _.Product.Name == name);

			if (priceFilter)
				result = result.OrderBy(_ => _.Price);

			RefreshGrid(result);
		}

		private async void BtnClear_Click(object sender, EventArgs e)
		{
			cbStore.SelectedItem = null;
			cbRegion.SelectedItem = null;
			cbCategory.SelectedItem = null;
			txtName.Text = "";
			cbExact.Checked = false;
			cbFullSearch.Checked = false;
			cbMinPrice.Checked = false;
			cbStore.Enabled = false;
			RefreshGrid(await _productService.GetAll());
		}

		private async void CbRegion_SelectedIndexChanged(object sender, EventArgs e)
		{
			var region = cbRegion.SelectedItem;
			if (region != null)
			{
				cbStore.Enabled = true;
				var stores = await _productService.GetStoresByRegion(region.ToString());
				FormHelper.RefreshComboboxDataSource(stores, bsStores, cbStore, "Name");
			}
			else
				cbStore.Enabled = false;
		}
	}
}

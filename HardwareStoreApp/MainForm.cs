using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

using HardwareStoreApp.Models;
using HardwareStoreApp.Services;
using HardwareStoreApp.Stores;
using HardwareStoreApp.Repositories;

namespace HardwareStoreApp
{
	// Использование внедрения зависимостей в WinForms
	//https://stackoverflow.com/questions/70475830/how-to-use-dependency-injection-in-winforms
	public partial class MainForm : Form
	{
		private readonly IAuthenticationService _authenticationService;
		private readonly IUserStore _userStore;
		private readonly IProductRepository _productRepository;

		public MainForm(
			IAuthenticationService authenticationService,
			IUserStore userStore,
			IProductRepository productRepository)
		{
			_authenticationService = authenticationService;
			_userStore = userStore;
			_productRepository = productRepository;
			InitializeComponent();
		}

		private async void MainForm_Load(object sender, EventArgs e)
		{
			_userStore.UserChanged += OnUserChanged;
			adminMenuItem.Visible = false;
			reportMenuItem.Visible = false;
			await _authenticationService.Register("Admin", "123", Role.Admin);

			RefreshGrid();
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

		private async void RefreshGrid()
		{
			var products = await _productRepository.Get();
			bsProduct.DataSource = products;

			bsProduct.ResetBindings(false);
			productGrid.DataSource = bsProduct;
		}

		private void AddProductsMenuItem_Click(object sender, EventArgs e)
		{
			ShowDialog<BalanceForm>();
		}

		private void SalesMenuItem_Click(object sender, EventArgs e)
		{
			ShowDialog<SalesForm>();
		}
	}
}

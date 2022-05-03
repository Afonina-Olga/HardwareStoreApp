using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

using HardwareStoreApp.Models;
using HardwareStoreApp.Services;
using HardwareStoreApp.Stores;

namespace HardwareStoreApp
{
	// Использование внедрения зависимостей в WinForms
	//https://stackoverflow.com/questions/70475830/how-to-use-dependency-injection-in-winforms
	public partial class MainForm : Form
	{
		private readonly IAuthenticationService _authenticationService;
		private readonly IUserStore _userStore;

		public MainForm(
			IAuthenticationService authenticationService,
			IUserStore userStore)
		{
			_authenticationService = authenticationService;
			_userStore = userStore;
			InitializeComponent();
		}

		private async void MainForm_Load(object sender, EventArgs e)
		{
			_userStore.UserChanged += OnUserChanged;
			adminMenuItem.Visible = false;
			reportMenuItem.Visible = false;
			await _authenticationService.Register("Admin", "123", Role.Admin);
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
				var form = Program.Services.GetRequiredService<LoginForm>();
				form.Show();
			}
		}

		private void ManageUsersMenuItem_Click(object sender, EventArgs e)
		{
			var form = Program.Services.GetRequiredService<ManageUserAccounts>();
			form.Show();
		}
	}
}

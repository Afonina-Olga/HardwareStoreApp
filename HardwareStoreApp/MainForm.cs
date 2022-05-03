using System;
using System.Windows.Forms;
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

		public MainForm(IAuthenticationService authenticationService, IUserStore userStore)
		{
			_authenticationService = authenticationService;
			_userStore = userStore;
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			_userStore.UserChanged += OnUserChanged;
			adminMenuItem.Visible = false;
			reportMenuItem.Visible = false;
		}

		private void OnUserChanged()
		{
			adminMenuItem.Visible = _userStore.Role == Role.Admin;
			reportMenuItem.Visible = _userStore.Login != null;
		}

		private async void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			_userStore.UserChanged -= OnUserChanged;
			await Program.HostInstance.StopAsync();
			Application.Exit();
		}

		private void loginMenuItem_Click(object sender, EventArgs e)
		{
			var loginForm = new LoginForm(_authenticationService, _userStore);
			loginForm.Show();
		}
	}
}

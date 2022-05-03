using System;
using System.Windows.Forms;
using HardwareStoreApp.Models;
using HardwareStoreApp.Services;
using HardwareStoreApp.Stores;
using Microsoft.Extensions.DependencyInjection;

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

		private void MainForm_Load(object sender, EventArgs e)
		{
			_userStore.UserChanged += OnUserChanged;
			adminMenuItem.Visible = false;
			reportMenuItem.Visible = false;
		}

		private void OnUserChanged()
		{
			adminMenuItem.Visible = true;// _userStore.Role == Role.Admin;
			reportMenuItem.Visible = true;// _userStore.Login != null;
		}

		private async void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			_userStore.UserChanged -= OnUserChanged;
			await Program.HostInstance.StopAsync();
			Application.Exit();
		}

		private void LoginMenuItem_Click(object sender, EventArgs e)
		{
			var form = Program.HostInstance.Services.GetRequiredService<LoginForm>();
			form.Show();
		}

		private void ManageUsersMenuItem_Click(object sender, EventArgs e)
		{
			var form = Program.HostInstance.Services.GetRequiredService<ManageUserAccounts>();
			form.Show();
		}
	}
}

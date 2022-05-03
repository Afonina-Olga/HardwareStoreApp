using HardwareStoreApp.Models;
using HardwareStoreApp.Services;
using System;
using System.Windows.Forms;

namespace HardwareStoreApp
{
	public partial class ManageUserAccounts : Form
	{
		private readonly IAuthenticationService _service;

		public ManageUserAccounts(IAuthenticationService service)
		{
			_service = service;
			InitializeComponent();
		}

		private async void BtnAdd_Click(object sender, System.EventArgs e)
		{
			var login = txtLogin.Text.Trim();
			var password = txtPassword.Text.Trim();
			var role = (string)cbRole.SelectedValue == "Администратор" ? Role.Admin : Role.Saler;

			if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
			{
				var result = await _service.Register(login, password, role);
				var message = result switch
				{
					RegistrationResult.Success => "Регистрация прошла успешно",
					RegistrationResult.UserAlreadyExists => "Пользователь с таким логином уже зарегистрирован",
					_ => throw new ArgumentException()
				};
				MessageBox.Show(message);
			}
			else
				MessageBox.Show("Заполните все поля");
		}

		private void BtnClose_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}

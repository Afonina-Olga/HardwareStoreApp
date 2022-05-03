using HardwareStoreApp.Services;
using HardwareStoreApp.Stores;
using System;
using System.Windows.Forms;

namespace HardwareStoreApp
{
	public partial class LoginForm : Form
	{
		private readonly IAuthenticationService _service;
		private readonly IUserStore _userStore;

		public LoginForm(IAuthenticationService service, IUserStore userStore)
		{
			_service = service;
			_userStore = userStore;
			InitializeComponent();
		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private async void BtnLogin_Click(object sender, EventArgs e)
		{
			try
			{
				var user = await _service.Login(txtLogin.Text.Trim(), txtPassword.Text.Trim());
				errorMessage.Text = user == null ? "Неверный логин или пароль" : string.Empty;

				if (user != null)
				{
					_userStore.SignIn(user.Login, user.Role);
					Close();
				}
			}
			catch
			{
				MessageBox.Show("Не удалось войти в систему", "Ошибка входа в систему", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}

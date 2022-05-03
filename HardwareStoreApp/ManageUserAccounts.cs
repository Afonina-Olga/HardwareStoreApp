using System;
using System.Linq;
using System.Windows.Forms;
using HardwareStoreApp.Models;
using HardwareStoreApp.Repositories;
using HardwareStoreApp.Services;
using HardwareStoreApp.ViewModels;

namespace HardwareStoreApp
{
	public partial class ManageUserAccounts : Form
	{
		private readonly IAuthenticationService _service;
		private readonly IUserRepository _repository;

		public ManageUserAccounts(IAuthenticationService service, IUserRepository userRepository)
		{
			_service = service;
			_repository = userRepository;

			InitializeComponent();
		}

		private async void BtnAdd_Click(object sender, EventArgs e)
		{
			var login = txtLogin.Text.Trim();
			var password = txtPassword.Text.Trim();
			var role = (string)cbRole.SelectedItem == "Администратор" ? Role.Admin : Role.Saler;

			if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
			{
				var result = await _service.Register(login, password, role);

				if (result == RegistrationResult.UserAlreadyExists)
					MessageBox.Show("Пользователь с таким логином уже зарегистрирован");
			}
			else
				MessageBox.Show("Заполните все поля");

			RefreshGrid();
		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ManageUserAccounts_Load(object sender, EventArgs e)
		{
			cbRole.SelectedIndex = 0;
			RefreshGrid();
			userGrid.AutoGenerateColumns = true;
			userGrid.Columns[0].Visible = false;
			SetColumnSettings(userGrid.Columns[1], "Логин");
			SetColumnSettings(userGrid.Columns[2], "Роль");

			userGrid.Columns.Add(new DataGridViewButtonColumn()
			{
				HeaderText = "Действие",
				Text = "Удалить",
				ToolTipText = "Удалить",
				UseColumnTextForButtonValue = true
			});
		}

		private void SetColumnSettings(DataGridViewColumn column, string name)
		{
			column.HeaderText = name;
			column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		private async void UserGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (sender is DataGridView dataGrid)
			{
				try
				{
					var id = (int)dataGrid["Id", e.RowIndex].Value;
					var result = await _service.Delete(id);
					if (result)
					{
						RefreshGrid();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Что-то пошло не так... " + ex.Message);
				}
			}
		}

		private async void RefreshGrid()
		{
			var users = await _repository.Get();
			userBindingSource.DataSource = users.Select(user => new UserViewModel()
			{
				Id = user.Id,
				Login = user.Login,
				Role = user.Role
			});

			userBindingSource.ResetBindings(false);
			userGrid.DataSource = userBindingSource;
		}
	}
}

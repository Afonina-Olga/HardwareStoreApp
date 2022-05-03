using HardwareStoreApp.Models;
using System;

namespace HardwareStoreApp.Stores
{
	public class UserStore : IUserStore
	{
		public string Login { get; set; }
		public Role Role { get; set; }
		public event Action UserChanged;

		public void Add(string login, Role role)
		{
			Login = login;
			Role = role;
			UserChanged?.Invoke();
		}

		public void Reset()
		{
			Login = null;
			Role = Role.User;
			UserChanged?.Invoke();
		}
	}
}

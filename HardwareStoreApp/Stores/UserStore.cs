using HardwareStoreApp.Models;
using System;

namespace HardwareStoreApp.Stores
{
	public class UserStore : IUserStore
	{
		public string Login { get; private set; }
		public Role Role { get; private set; }
		public bool IsSignedIn { get; private set; }

		public event Action UserChanged;

		public void SignIn(string login, Role role)
		{
			IsSignedIn = true;
			Login = login;
			Role = role;
			UserChanged?.Invoke();
		}

		public void SignOut()
		{
			IsSignedIn = false;
			Login = null;
			Role = Role.User;
			UserChanged?.Invoke();
		}
	}
}

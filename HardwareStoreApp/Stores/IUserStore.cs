using HardwareStoreApp.Models;
using System;

namespace HardwareStoreApp.Stores
{
	public interface IUserStore
	{
		string Login { get;  }

		Role Role { get;  }

		bool IsSignedIn { get;  }

		event Action UserChanged;

		void SignIn(string login, Role role);

		void SignOut();
	}
}

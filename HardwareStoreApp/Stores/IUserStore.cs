using HardwareStoreApp.Models;
using System;

namespace HardwareStoreApp.Stores
{
	public interface IUserStore
	{
		string Login { get; set; }

		Role Role { get; set; }

		event Action UserChanged;

		void Add(string login, Role role);

		void Reset();
	}
}

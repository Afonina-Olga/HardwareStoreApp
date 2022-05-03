using HardwareStoreApp.Models;

namespace HardwareStoreApp.ViewModels
{
	internal class UserViewModel
	{
		public int Id { get; set; }

		public string Login { get; set; }

		public Role Role { get; set; }
	}
}

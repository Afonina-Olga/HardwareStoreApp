using HardwareStoreApp.Models;
using System.Threading.Tasks;

namespace HardwareStoreApp.Services
{
	public interface IAuthenticationService
	{
		Task<User> Login(string login, string password);
	}
}

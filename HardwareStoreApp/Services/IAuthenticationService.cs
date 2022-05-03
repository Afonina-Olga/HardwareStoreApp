using HardwareStoreApp.Models;
using System.Threading.Tasks;

namespace HardwareStoreApp.Services
{
	public interface IAuthenticationService
	{
		Task<User> Login(string login, string password);

		Task<RegistrationResult> Register(string login, string password, Role role);

		Task<bool> Delete(int id);
	}
}

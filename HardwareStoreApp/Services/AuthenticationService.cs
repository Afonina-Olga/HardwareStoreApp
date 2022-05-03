using System.Threading.Tasks;

using HardwareStoreApp.Models;
using HardwareStoreApp.Repositories;

namespace HardwareStoreApp.Services
{
	public class AuthenticationService : IAuthenticationService
	{
		private readonly IUserRepository _userRepository;

		public AuthenticationService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		public async Task<User> Login(string login, string password)
		{
			var user = await _userRepository.Get(login, password);
			return user;
		}
	}
}

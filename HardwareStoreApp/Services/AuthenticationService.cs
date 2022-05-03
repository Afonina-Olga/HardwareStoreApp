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

		public async Task<bool> Delete(int id)
		{
			return await _userRepository.Delete(id);
		}

		public async Task<User> Login(string login, string password)
		{
			var user = await _userRepository.Get(login, password);
			return user;
		}

		public async Task<RegistrationResult> Register(string login, string password, Role role)
		{
			var user = await _userRepository.Get(login);
			
			if (user != null)
				return RegistrationResult.UserAlreadyExists;

			await _userRepository.Create(new User()
			{
				Login = login,
				Password = password,
				Role = role
			});

			return RegistrationResult.Success;
		}
	}
}

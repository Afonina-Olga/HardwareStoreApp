using HardwareStoreApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace HardwareStoreApp.Repositories
{
	public class UserRepository : Repository<User>, IUserRepository
	{
		private readonly HardwareStoreAppDbContextFactory _contextFactory;

		public UserRepository(HardwareStoreAppDbContextFactory contextFactory)
			: base(contextFactory)
		{
			_contextFactory = contextFactory;
		}

		/// <summary>
		/// Поиск пользователя по логину и паролю
		/// </summary>
		/// <param name="login">Логин</param>
		/// <param name="password">Пароль</param>
		/// <returns>Найденный пользователь</returns>
		public async Task<User> Get(string login, string password)
		{
			using var context = _contextFactory.CreateDbContext();
			var user = await context.Users.FirstOrDefaultAsync(
				user => user.Login == login && user.Password == password);
			return user;
		}

		/// <summary>
		/// Поиск пользователя по логину
		/// </summary>
		/// <param name="login">Логин</param>
		/// <returns>Найденный пользователь</returns>
		public async Task<User> Get(string login)
		{
			using var context = _contextFactory.CreateDbContext();
			var user = await context.Users
				.FirstOrDefaultAsync(user => user.Login == login);
			return user;
		}
	}
}

using HardwareStoreApp.Models;
using System.Threading.Tasks;

namespace HardwareStoreApp.Repositories
{
	public interface IUserRepository : IRepository<User>
	{
		Task<User> Get(string login, string password);
		Task<User> Get(string login);
	}
}

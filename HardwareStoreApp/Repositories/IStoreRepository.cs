using System.Threading.Tasks;

using HardwareStoreApp.Models;

namespace HardwareStoreApp.Repositories
{
	public interface IStoreRepository : IRepository<Store>
	{
		Task<bool> IsExists(string region, string name);
	}
}

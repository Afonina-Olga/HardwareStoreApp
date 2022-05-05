using System.Collections.Generic;
using System.Threading.Tasks;

using HardwareStoreApp.Models;

namespace HardwareStoreApp.Repositories
{
	public interface IStoreRepository : IRepository<Store>
	{
		Task<bool> IsExists(string region, string name);

		Task<IEnumerable<Address>> GetLocations();

		Task<IEnumerable<Store>> GetStores();

		Task<IEnumerable<Store>> GetStoresByRegion(string region);
	}
}

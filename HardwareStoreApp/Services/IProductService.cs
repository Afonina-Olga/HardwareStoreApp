using System.Collections.Generic;
using System.Threading.Tasks;

using HardwareStoreApp.Models;

namespace HardwareStoreApp.Services
{
	public interface IProductService
	{
		Task<IEnumerable<Balance>> GetAll();

		Task<string[]> GetCategories();

		Task<IEnumerable<Store>> GetStores();

		Task<string[]> GetRegions();

		Task<IEnumerable<Store>> GetStoresByRegion(string region);

		Task<IEnumerable<Balance>> Find(
			string region,
			string store,
			string name,
			string category,
			bool fullSearcMode);
	}
}

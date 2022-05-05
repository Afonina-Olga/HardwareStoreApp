using HardwareStoreApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HardwareStoreApp.Repositories
{
	public interface IBalanceRepository : IRepository<Balance>
	{
		Task<Balance> Get(int productId, int storeId, decimal price);

		Task<Balance> Get(int productId, int storeId, bool inStock = false);

		Task<IEnumerable<Balance>> Get(bool inStock = false);
	}
}

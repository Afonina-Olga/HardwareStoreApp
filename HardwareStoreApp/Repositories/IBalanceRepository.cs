using HardwareStoreApp.Models;
using System.Threading.Tasks;

namespace HardwareStoreApp.Repositories
{
	public interface IBalanceRepository:IRepository<Balance>
	{
		Task<Balance> Get(int productId, int storeId, decimal price);
	}
}

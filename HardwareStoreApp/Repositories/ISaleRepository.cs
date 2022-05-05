using HardwareStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HardwareStoreApp.Repositories
{
	public interface ISaleRepository : IRepository<Sale>
	{
		Task<IEnumerable<Sale>> GetByStore(DateTime start, DateTime end, int? id = null);

		Task<IEnumerable<Sale>> Get(DateTime start, DateTime end);
	}
}

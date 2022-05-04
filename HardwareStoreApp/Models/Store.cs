using System.Collections.Generic;

namespace HardwareStoreApp.Models
{
	/// <summary>
	///  Магазин
	/// </summary>
	public class Store : DomainObject
	{
		/// <summary>
		/// Название магазина
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Адрес
		/// </summary>
		public Address Address { get; set; }

		public Sale Sale { get; set; }

		public List<Product> Products { get; set; }
	}
}

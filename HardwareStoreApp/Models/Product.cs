using System.Collections.Generic;

namespace HardwareStoreApp.Models
{
	/// <summary>
	/// Товар
	/// </summary>
	public class Product : DomainObject
	{
		/// <summary>
		/// Название категория
		/// </summary>
		public Category Category { get; set; }

		/// <summary>
		/// Название товара
		/// </summary>
		public string Name { get; set; }

		public List<Sale> Sales { get; set; }

		public List<Store> Stores { get; set; }
	}
}

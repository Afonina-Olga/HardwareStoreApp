using System;

namespace HardwareStoreApp.Models
{
	/// <summary>
	/// Продажа
	/// </summary>
	public class Sale : DomainObject
	{
		/// <summary>
		/// Дата
		/// </summary>
		public DateTime Date { get; set; }

		/// <summary>
		/// Цена
		/// </summary>
		public decimal Price { get; set; }

		/// <summary>
		/// Количество
		/// </summary>
		public int Count { get; set; }

		/// <summary>
		/// Товар
		/// </summary>
		public Product Product { get; set; }

		/// <summary>
		/// Внешний ключ в таблице Product
		/// </summary>
		public int IdProduct { get; set; }

		/// <summary>
		/// Магазин
		/// </summary>
		public Store Store { get; set; }

		public int IdStore { get; set; }
	}
}

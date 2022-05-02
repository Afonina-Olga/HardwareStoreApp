namespace HardwareStoreApp.Models
{
	/// <summary>
	///  Магазин
	/// </summary>
	public class Store : DomainObject
	{
		/// <summary>
		/// Адрес
		/// </summary>
		public Address Address { get; set; }

		public Sale Sale { get; set; }

		public int SaleId { get; set; }

		public Balance Balance { get; set; }

		public int BalanceId { get; set; }
	}
}

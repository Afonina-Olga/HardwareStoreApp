namespace HardwareStoreApp.Models
{
	/// <summary>
	/// Пользователь
	/// </summary>
	public class User : DomainObject
	{
		/// <summary>
		/// Логин
		/// </summary>
		public string Login { get; set; }

		/// <summary>
		/// Пароль
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// Роль
		/// </summary>
		public Role Role { get; set; }
	}
}

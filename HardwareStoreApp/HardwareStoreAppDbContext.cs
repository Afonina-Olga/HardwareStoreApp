using HardwareStoreApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HardwareStoreApp
{
	public class HardwareStoreAppDbContext : DbContext
	{
		public DbSet<User> Users { get; set; }

		public DbSet<Sale> Sales { get; set; }

		public DbSet<Store> Stores { get; set; }

		public DbSet<Product> Products { get; set; }

		public DbSet<Balance> Balances { get; set; }

		public HardwareStoreAppDbContext(DbContextOptions options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			#region Users table

			modelBuilder.Entity<User>().Property(_ => _.Role).IsRequired();
			modelBuilder.Entity<User>().Property(_ => _.Login).IsRequired();
			modelBuilder.Entity<User>().Property(_ => _.Password).IsRequired();
			modelBuilder.Entity<User>().Property(_ => _.Login).HasMaxLength(50);
			modelBuilder.Entity<User>().Property(_ => _.Password).HasMaxLength(20);

			#endregion

			#region Products table

			modelBuilder.Entity<Product>().Property(_ => _.Name).IsRequired();
			modelBuilder.Entity<Product>().Property(_ => _.Name).HasMaxLength(100);
			modelBuilder.Entity<Product>().OwnsOne(_ => _.Category);

			#endregion

			#region Sales table

			modelBuilder.Entity<Sale>().Property(_ => _.Date).IsRequired();
			modelBuilder.Entity<Sale>().Property(_ => _.Price).IsRequired();

			#endregion

			#region Store table

			modelBuilder.Entity<Store>().OwnsOne(_ => _.Address);
			modelBuilder.Entity<Store>().Property(_ => _.Name);

			#endregion

			#region Balances table

			modelBuilder.Entity<Balance>().Property(_ => _.Price).IsRequired();
			modelBuilder.Entity<Balance>().Property(_ => _.Count).IsRequired();

			#endregion

			//#region Relations

			//modelBuilder
			//	.Entity<Store>()
			//	.HasMany(_ => _.Products)
			//	.WithMany(_ => _.Stores)
			//	.UsingEntity<Sale>(
			//		sale => sale
			//			.HasOne(_ => _.Product)
			//			.WithMany()
			//			.HasForeignKey(_ => _.ProductId),
			//		sale => sale
			//			.HasOne(_ => _.Store)
			//			.WithMany()
			//			.HasForeignKey(_ => _.StoreId))
			//	.ToTable(nameof(Sale));

			//modelBuilder
			//	.Entity<Store>()
			//	.HasMany(_ => _.Products)
			//	.WithMany(_ => _.Stores)
			//	.UsingEntity<Balance>(
			//		balance => balance
			//			.HasOne(_ => _.Product)
			//			.WithMany()
			//			.HasForeignKey(_ => _.ProductId),
			//		balance => balance
			//			.HasOne(_ => _.Store)
			//			.WithMany()
			//			.HasForeignKey(_ => _.StoreId))
			//	.ToTable(nameof(Balance));
			
			//#endregion

			base.OnModelCreating(modelBuilder);
		}
	}
}

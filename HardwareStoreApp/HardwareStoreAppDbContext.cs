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

			modelBuilder.Entity<Product>()
				.HasMany(c => c.Stores)
				.WithMany(s => s.Products)
				.UsingEntity<Sale>(
					_ => _
						.HasOne(_ => _.Store)
						.WithMany()
						.HasForeignKey(_ => _.IdStore),
					_ => _
						.HasOne(_ => _.Product)
						.WithMany()
						.HasForeignKey(_ => _.IdProduct))
				.ToTable(nameof(Sale));

			modelBuilder.Entity<Product>()
				.HasMany(c => c.Stores)
				.WithMany(s => s.Products)
				.UsingEntity<Balance>(
					pi => pi
						.HasOne(_ => _.Store)
						.WithMany()
						.HasForeignKey(_ => _.StoreId),
					pi => pi
						.HasOne(_ => _.Product)
						.WithMany()
						.HasForeignKey(_ => _.ProductId))
				.ToTable(nameof(Balance));

			#endregion

			base.OnModelCreating(modelBuilder);
		}
	}
}

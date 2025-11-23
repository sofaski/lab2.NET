using LabEntityFrameworkShop.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace LabEntityFrameworkShop.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "..", "..", "..", "shop.db");

            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, CategoryName = "Електроніка" },
                new Category { Id = 2, CategoryName = "Одяг" },
                new Category { Id = 3, CategoryName = "Продукти харчування" }
            );

            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { Id = 1, SupplierName = "Global Trade", Country = "Germany" },
                new Supplier { Id = 2, SupplierName = "Local Market", Country = "Ukraine" }
            );
        }
    }
}

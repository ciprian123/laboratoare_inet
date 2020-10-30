using API.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Console.WriteLine("Hello there!");
            modelBuilder.Entity<Product>().HasData(
                ProductFactory.CreateProduct(10, "PlayStation 5", 500, new DateTime(2020, 6, 1, 7, 47, 0), new DateTime(2022, 6, 1, 7, 47, 0)),
                ProductFactory.CreateProduct(11, "xBox One", 400, new DateTime(2020, 6, 1, 7, 47, 0), new DateTime(2022, 6, 1, 7, 47, 0)),
                ProductFactory.CreateProduct(12, "Smart TV OLED", 1500, new DateTime(2020, 6, 1, 7, 47, 0), new DateTime(2022, 6, 1, 7, 47, 0)),
                ProductFactory.CreateProduct(13, "Tastatura RGB", 500, new DateTime(2020, 6, 1, 7, 47, 0), new DateTime(2022, 6, 1, 7, 47, 0)),
                ProductFactory.CreateProduct(14, "Monitor 4k", 1500, new DateTime(2020, 6, 1, 7, 47, 0), new DateTime(2022, 6, 1, 7, 47, 0))
            );
        }
    }
}
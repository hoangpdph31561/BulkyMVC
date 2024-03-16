using Bulky.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Drink", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Food", DisplayOrder = 2 });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Coca Cola",
                    Description = "Coca Cola 1.5L",
                    ISBN = "123456789",
                    Author = "Coca Cola",
                    ListPrice = 2.99,
                    Price = 2.99,
                    Price50 = 2.89,
                    Price100 = 2.79
                },
                new Product
                {
                    Id = 2,
                    Title = "Pepsi",
                    Description = "Pepsi 1.5L",
                    ISBN = "987654321",
                    Author = "Pepsi",
                    ListPrice = 3.99,
                    Price = 3.99,
                    Price50 = 3.89,
                    Price100 = 3.79
                });
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

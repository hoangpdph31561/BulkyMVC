using BulkyWebRazor_Temp.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWebRazor_Temp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
               new Category { Id = 1, Name = "Drink", DisplayOrder = 1 },
               new Category { Id = 2, Name = "Food", DisplayOrder = 2 });
        }
        public DbSet<Category> Categories { get; set; }
    }

}

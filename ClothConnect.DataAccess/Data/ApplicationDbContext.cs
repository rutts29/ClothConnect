
using ClothConnect.Models;
using Microsoft.EntityFrameworkCore;

namespace ClothConnect.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
        public DbSet <Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Stiped Shirt", DisplayOrder = 5 },
                new Category { Id = 2, Name = "Denim Jacket", DisplayOrder = 2 },
                new Category { Id = 3, Name = "White Sneakers", DisplayOrder = 3 }
                );
        }

    }
}

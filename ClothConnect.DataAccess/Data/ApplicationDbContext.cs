using ClothConnect.Models;
using ClothConnect.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace ClothConnect.DataAccess.Data
{
    // Defines the database context for ClothConnect application
    public class ApplicationDbContext : DbContext
    {
        // Constructor for the ApplicationDbContext with options
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        // DbSet for Categories table
        public DbSet <Category> Categories { get; set; }
        // DbSet for Products table
        public DbSet<Product> Products { get; set; }

        // Overriding the OnModelCreating method to configure the model
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding the Category table with initial data
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Gown", DisplayOrder = 5 },
                new Category { Id = 2, Name = "Jacket", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Dress", DisplayOrder = 3 }
                );

            // Seeding the Product table with initial data
            modelBuilder.Entity<Product>().HasData(
               new Product
               {
                   Id = 1,
                   Title = "Elegant Evening Gown",
                   Seller = "Sophia Lorenz",
                   Description = "Exquisite evening gown perfect for gala events. Features a sleek silhouette and luxurious fabric that gracefully flows to the floor.",
                   ItemCode = "ELEG001122",
                   ListPrice = 120,
                   Price = 115,
                   Price50 = 110,
                   Price100 = 105,
                   CategoryId=1
               },
               new Product
               {
                   Id = 2,
                   Title = "Classic Leather Jacket",
                   Seller = "Mike Johnson",
                   Description = "A timeless leather jacket, ideal for adding an edge to any outfit. Made with premium quality leather for durability and style.",
                   ItemCode = "CLJ8889002",
                   ListPrice = 200,
                   Price = 190,
                   Price50 = 180,
                   Price100 = 170,
                   CategoryId = 2
               },
               new Product
               {
                   Id = 3,
                   Title = "Summer Breeze Maxi Dress",
                   Seller = "Luna Rodriguez",
                   Description = "Flowy and light, this maxi dress is perfect for sunny days. Features a floral print and a comfortable, airy design.",
                   ItemCode = "SBMD5555003",
                   ListPrice = 80,
                   Price = 75,
                   Price50 = 70,
                   Price100 = 65,
                   CategoryId = 3
               });
        }
    }
}

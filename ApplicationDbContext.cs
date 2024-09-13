using Microsoft.EntityFrameworkCore;
using project.Models;

using project;

namespace project.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Project;Trusted_Connection=True;Encrypt=false");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding
            var _Categories = new List<Category>
            {
                new Category { CategoryId = 1, Name = "Electronics" },
                new Category { CategoryId = 2, Name = "Clothing" },
                new Category { CategoryId = 3, Name = "Books" },
                new Category { CategoryId = 4, Name = "Furniture" }
            };
            /*-----------------------------------------------------*/
            var _Products = new List<Product>
            {
                new Product {  Title = "Laptop", Price = 1234, Description = "A powerful laptop", Quantity = 10, ImagePath = "laptop.jpg", CategoryId = 1 },
                new Product {   Title = "T-Shirt", Price = 2234, Description = "A stylish T-Shirt", Quantity = 20, ImagePath = "tshirt.jpg", CategoryId = 2 },
                new Product {  Title = "Novel", Price = 3234, Description = "An interesting novel", Quantity = 30, ImagePath = "novel.jpg", CategoryId = 3 },
                new Product {  Title = "Sofa", Price = 4234, Description = "A comfortable sofa", Quantity = 40, ImagePath = "sofa.jpg", CategoryId = 4 },
                new Product {  Title = "Smartphone", Price = 5234, Description = "A latest smartphone", Quantity = 50, ImagePath = "smartphone.jpg", CategoryId = 1 },
                new Product {  Title = "Dress", Price = 6234, Description = "A beautiful dress", Quantity = 60, ImagePath = "dress.jpg", CategoryId = 2 },
                new Product {  Title = "Textbook", Price = 7234, Description = "A textbook for study", Quantity = 70, ImagePath = "textbook.jpg", CategoryId = 3 },
                new Product {  Title = "Table", Price = 8234, Description = "A sturdy table", Quantity = 80, ImagePath = "table.jpg", CategoryId = 4 },
                new Product {  Title = "Headphones", Price = 9234, Description = "High-quality headphones", Quantity = 90, ImagePath = "headphones.jpg", CategoryId = 1 },
                new Product {  Title = "Jeans", Price = 10234, Description = "Durable jeans", Quantity = 100, ImagePath = "jeans.jpg", CategoryId = 2 },
                new Product {  Title = "Cookbook", Price = 11234, Description = "A delicious cookbook", Quantity = 110, ImagePath = "cookbook.jpg", CategoryId = 3 },
                new Product { Title = "Bed", Price = 12234, Description = "A comfortable bed", Quantity = 120, ImagePath = "bed.jpg", CategoryId = 4 }
            };

            /*-----------------------------------------------------*/
            modelBuilder.Entity<Category>().HasData(_Categories);
            modelBuilder.Entity<Product>().HasData(_Products);
            /*-----------------------------------------------------*/
        }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Product> Products { get; set; }
    }
}
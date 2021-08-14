using DatabaseGeneration.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseGeneration.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>(entity => { entity.HasIndex(p => p.Name).IsUnique(); });
            
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1, Name = "Burger",Currency = "50", Category = "launch"
            },
            new Product
            {
                Id = 2, Name = "bread",Currency = "25", Category = "breakfast"
 
            },
            new Product
            {
                Id = 3, Name = "fish",Currency = "35", Category = "dinner"
 
            }
            );
        }
        
        public DbSet<Product> Products { get; set; }


    }
}
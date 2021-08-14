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
            
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Product)
                .WithMany(p =>p.Orders );
            modelBuilder.Entity<Product>(entity => { entity.HasIndex(p => p.Name).IsUnique(); });
            
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1, Name = "rice",Currency = "50", Category = "Grains"
            },
            new Product
            {
                ProductId = 2, Name = "oates",Currency = "25", Category = "cereals"
 
            },
            new Product
            {
                ProductId = 3, Name = "fish",Currency = "35", Category = "protein"
 
            }
            );
        }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        


    }
}
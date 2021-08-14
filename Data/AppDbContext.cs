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
        }
        
        public DbSet<Product> Products { get; set; }


    }
}
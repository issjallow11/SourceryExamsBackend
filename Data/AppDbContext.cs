using DatabaseGeneration.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseGeneration.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        
        public DbSet<Product> Products { get; set; }


    }
}
using System.Collections.Generic;
using System.Linq;
using DatabaseGeneration.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseGeneration.Data.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;
        
        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
            //throw new System.NotImplementedException();
            return _context.Products.OrderBy(p => p.Name).ToList();
        }

        public Product GetById(int id)
        {
            //throw new System.NotImplementedException();
            return _context.Products.SingleOrDefault(p => p.Id == id);
        }

        public void AddProduct(Product product)
        {
            //throw new System.NotImplementedException();
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            //throw new System.NotImplementedException();
            _context.Entry(product).State = EntityState.Modified; 
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            //throw new System.NotImplementedException();
            Product product = _context.Products.SingleOrDefault(p => p.Id == id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
using System.Collections.Generic;
using DatabaseGeneration.Models;

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
            throw new System.NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void AddProduct(Product category)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateProduct(Product category)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
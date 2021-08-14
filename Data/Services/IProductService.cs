using System.Collections.Generic;
using DatabaseGeneration.Models;

namespace DatabaseGeneration.Data.Services
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
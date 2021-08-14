using System.Collections.Generic;
using DatabaseGeneration.Models;

namespace DatabaseGeneration.Data.Services
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        void AddProduct(Product category);
        void UpdateProduct(Product category);
        void DeleteProduct(int id);
    }
}
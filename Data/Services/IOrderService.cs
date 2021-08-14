using System.Collections.Generic;
using DatabaseGeneration.Models;

namespace DatabaseGeneration.Data.Services
{
    public interface IOrderService
    {
        List<Order> GetAll();
        Order GetById(int id);
        void AddOrder(Order order);
        void UpdateProduct(Order order);
        void DeleteProduct(int id);
    }
}
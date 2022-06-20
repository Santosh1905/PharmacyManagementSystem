using PharmacyManagementSystem.Models;
using System.Collections.Generic;

namespace PharmacyManagementSystem.Repository
{
    public interface IOrdersRepostiory
    {
        IEnumerable<Order> GetAll();
        Order Create(Order order);

        IEnumerable<Order> GetOrders(int id);
    }
}
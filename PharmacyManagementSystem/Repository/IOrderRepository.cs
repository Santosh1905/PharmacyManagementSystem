using PharmacyManagementSystem.Models;
using System.Collections.Generic;

namespace PharmacyManagementSystem.Repository
{
    public interface IOrderRepository
    {
        OrderDetail Create(OrderDetail orderDetail);
        IEnumerable<OrderDetail> GetAll();

        OrderDetail GetOrder(int id);
        void DeleteOrder(int id);
        void UpdateOrder(OrderDetail orderDetail);
    }
}
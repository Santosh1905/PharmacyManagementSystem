using Microsoft.EntityFrameworkCore;
using PharmacyManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace PharmacyManagementSystem.Repository
{
    public class OrdersRepository : IOrdersRepostiory
    {
        private readonly pharmacyManagement1Context _context;
        public OrdersRepository(pharmacyManagement1Context context)
        {
            _context = context;
        }

        public Order Create(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();

            return order;
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.Include(ordr => ordr.User).ToList();
            //return _context.SupplierDetails.Include(drug => drug.DrugDetails).ToList();
        }


        public IEnumerable<Order> GetOrders(int id)
        {
            var order = _context.Orders.Where(u => u.UserId == id).ToList();
            return order;

        }


    }
}
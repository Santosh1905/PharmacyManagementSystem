using Microsoft.EntityFrameworkCore;
using PharmacyManagementSystem.Models;
using PharmacyManagementSystem.Repository;
using System.Collections.Generic;
using System.Linq;

namespace PharmacyManagementSystem.Repository
{
    public class SupplierRepository : ISuplierRepository
    {
        private readonly pharmacyManagement1Context _context;

        public SupplierRepository(pharmacyManagement1Context context)
        {
            _context = context;
        }
        public SupplierDetail Create(SupplierDetail supplierDetail)
        {
            _context.SupplierDetails.Add(supplierDetail);
            _context.SaveChanges();

            return supplierDetail;
        }
        public void DeleteSupplier(int id)
        {
            SupplierDetail supplier = GetSupplier(id);
            _context.Remove(supplier);
            _context.SaveChanges();
        }

        public IEnumerable<SupplierDetail> GetAll()
        {
            return _context.SupplierDetails.Include(drug => drug.DrugDetails).ToList();
        }
        public SupplierDetail GetSupplier(int id)
        {
            var supplier = _context.SupplierDetails.Where(u => u.SupplierId == id).Include(c => c.DrugDetails).FirstOrDefault();
            return supplier;

            //var supplier = _context.SupplierDetails.Where(u => u.SupplierId == id).Include(c => c.DrugDetails).ToList();
            //return supplier;
        }
        //var products = await _context.Products.Where(p => p.UserId == userId).Include(c => c.Orders)
        //        .ToListAsync();
        //    return products;
        public void UpdateSupplier(SupplierDetail supplierDetail)
        {
            _context.Entry(supplierDetail).State = EntityState.Modified;
            _context.SaveChanges();

        }
    }
}
using System;
using System.Collections.Generic;

#nullable disable

namespace PharmacyManagementSystem.Models
{
    public partial class DrugDetail
    {
        public DrugDetail()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int DrugId { get; set; }
        public string DrugName { get; set; }
        public int Quantity { get; set; }
        public DateTime? ExpiryDate { get; set; } = DateTime.Now;
        public decimal? Price { get; set; }
        public int? SupplierId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual SupplierDetail Supplier { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

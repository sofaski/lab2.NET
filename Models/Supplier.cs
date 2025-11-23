using System.Collections.Generic;

namespace LabEntityFrameworkShop.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public string Country { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}

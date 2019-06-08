using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public int Stock { get; set; }
        public bool isStock { get; set; }


        public virtual Category Category { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

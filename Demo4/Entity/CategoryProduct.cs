using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4.Entity
{
    public class CategoryProduct:BaseEntity
    {
        public int CategoryId { get; set; }
        public int ProductId { get; set; }

        public Category Category { get; set; }

        public Product Product { get; set; }
    }
}
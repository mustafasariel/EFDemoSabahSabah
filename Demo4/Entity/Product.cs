using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4.Entity
{
    public class Product : BaseEntity, IAuditEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }

        public List<CategoryProduct> ProductCategories { get; set; }


        public Product()
        {
            ProductCategories = new List<CategoryProduct>();

        }
    }
}

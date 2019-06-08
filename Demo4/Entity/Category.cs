using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4.Entity
{
    public class Category : BaseEntity, IAuditEntity
    {

        public string Name { get; set; }

        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }

        public List<CategoryProduct> CategoryProducts { get; set; }

        public string ImageUrl { get; set; }


        public Category()
        {
            CreateDate = DateTime.Now;
            CategoryProducts = new List<CategoryProduct>();
        }

        public override string ToString()
        {
            return $"{Name} {CreateDate.ToLongTimeString()}";
        }
    }
}
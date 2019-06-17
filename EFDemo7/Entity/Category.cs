using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo7.Entity
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}

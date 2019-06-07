using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4.Entity.Maping
{
   public class ProductMap:EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            this.HasKey(t => t.Id);

            this.ToTable("Products");

            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}

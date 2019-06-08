using Demo5.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5.EF.Mapping
{
    public class ProductMapping: EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            this.HasKey(t => t.ProductId);

            this.Property(t => t.ProductName).HasMaxLength(50).IsUnicode(false).HasColumnName("ProductName");

           
            this.ToTable("msa.Products");



        }
    }
}

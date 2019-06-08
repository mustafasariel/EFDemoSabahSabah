using Demo5.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5.EF.Mapping
{
    public class CustomerMapping:EntityTypeConfiguration<Customer>
    {
        public CustomerMapping()
        {
            this.HasKey(t => t.CustomerId);

            this.Property(t => t.CustomerName).HasMaxLength(30).IsUnicode(false).HasColumnName("CustomerName");
            this.Property(t => t.CustomerLastname).HasMaxLength(30).IsUnicode(false).HasColumnName("CustomerLastName");


            this.ToTable("msa.Customers");

            
        }
    }
}
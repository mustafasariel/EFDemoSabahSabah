using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFluentApiDemo.Entities.EFMapping
{
  public  class CustomerMap:EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            this.HasKey(t => t.CustomerID);

           // this.Property(t => t.CustomerID).IsRequired().HasMaxLength(5);
            this.Property(t => t.CompanyName).IsRequired().HasMaxLength(40).IsUnicode(false);
            this.Property(t => t.CityCode).IsOptional();
            this.Property(t => t.ContactName).HasMaxLength(30).IsUnicode(false);
            this.Property(t => t.Country).HasMaxLength(15);
            

            this.ToTable("msa.Customers");


            // default olsa bile burası öenmlidir. yapılmalıdır.
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.ContactName).HasColumnName("ContactName");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.CityCode).HasColumnName("CityCode");
           this.Property(t => t.CreateDate).HasColumnName("CreateDate");

        }
    }
}

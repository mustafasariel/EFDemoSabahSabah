using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFluentApiDemo.Entities.EFMapping
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            this.HasKey(t => t.OrderID);

            //this.Property(t => t.CustomerID).IsRequired();


            this.ToTable("msa.Orders");

            this.Property(t => t.CustomerID).HasColumnName("CustomerId");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");
            // this.Property(t => t.CreateDate).HasColumnName("CreateDate");

           
        }
    }
}

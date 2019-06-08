using Demo5.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5.EF.Mapping
{
   public  class OrderMapping: EntityTypeConfiguration<Order>
    {
        public OrderMapping()
        {
            this.HasIndex(t => t.OrderId);


            this.ToTable("msa.Order");
        }
    }
}

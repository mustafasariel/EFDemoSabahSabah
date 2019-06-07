using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4.Entity.Maping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            this.HasKey(t => t.Id);

            this.ToTable("Categories");


            this.Property(t => t.Name).HasColumnName("Name");

        }

    }
}

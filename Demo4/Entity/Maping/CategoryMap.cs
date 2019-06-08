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

            this.Property(t => t.ImageUrl).HasMaxLength(250).IsUnicode(false);
            this.Property(t => t.Name).IsUnicode(false).HasMaxLength(50);
            this.Property(t => t.CreateBy).HasMaxLength(40).IsUnicode(false);
            this.Property(t => t.UpdateBy).HasMaxLength(40).IsUnicode(false);


            this.ToTable("Categories");
      

            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ImageUrl).HasColumnName("ImageUrl");

        }

    }
}

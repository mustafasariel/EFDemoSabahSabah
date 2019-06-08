using Demo5.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5.EF.Mapping
{
    public class CategoryMapping: EntityTypeConfiguration<Category>
    {
        public CategoryMapping()
        {
            this.HasKey(t => t.CategoryId);

            this.Property(t => t.CategoryName).HasMaxLength(40).IsUnicode(false).HasColumnName("CategoryName"); ;

            this.ToTable("msa.Categories");
        }
    }
}

using System.Data.Entity.ModelConfiguration;

namespace EFDemo6.Entity
{
    public class StudentConfigurations : EntityTypeConfiguration<Student>
    {
        public StudentConfigurations()
        {
            this.Property(s => s.StudentName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(s => s.StudentName)
                .IsConcurrencyToken();

            // Configure a one-to-one relationship between Student & StudentAddress
            this.HasOptional(s => s.Address) // Mark Student.Address property optional (nullable)
                .WithRequired(ad => ad.Student); // Mark Address.Student property as required (NotNull).
        }
    }
}
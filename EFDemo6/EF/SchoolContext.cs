using EF6CodeFirstDemo;
using EFDemo6.Entity;
using System.Data.Entity;

namespace EFDemo6.EF
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=myContext")
        {
            Database.SetInitializer<SchoolContext>(new SchoolDBInitializer());

            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Adds configurations for Student from separate class
            modelBuilder.Configurations.Add(new StudentConfigurations());

            modelBuilder.Entity<Teacher>().ToTable("TeacherInfo");

            modelBuilder.Entity<Teacher>().MapToStoredProcedures();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
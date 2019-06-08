
using CodeFirstFluentApiDemo.Entities;
using CodeFirstFluentApiDemo.Entities.EFMapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFluentApiDemo.Contexts
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext() : base("Name=myContext")
        {
            Database.SetInitializer<NorthwindContext>(new DropCreateDatabaseAlways<NorthwindContext>());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap()); ;
            modelBuilder.Configurations.Add(new OrderMap());


            modelBuilder.Entity<Order>()
           .HasRequired<Customer>(s => s.Customer)
           .WithMany(g => g.Orders)
           .HasForeignKey<int>(s => s.CustomerID);




        }
    }
}

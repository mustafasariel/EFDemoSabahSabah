using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo5.Entity;

namespace Demo5.EF
{
    public class MyContext :DbContext
    {

        public MyContext() : base("name=myContext")
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<MyContext>());
           // Database.SetInitializer(new MyContextInitializer());

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EF.Mapping.CategoryMapping());
            modelBuilder.Configurations.Add(new EF.Mapping.CustomerMapping());
            modelBuilder.Configurations.Add(new EF.Mapping.OrderMapping());
            modelBuilder.Configurations.Add(new EF.Mapping.ProductMapping());


            //modelBuilder.Ignore<Category>();
        }
    }
}

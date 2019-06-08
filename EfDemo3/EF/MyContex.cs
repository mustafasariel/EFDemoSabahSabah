using EfDemo3.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDemo3.EF
{
    public class MyContext : DbContext
    {
        // Use the constructor to target a specific named connection string
        public MyContext()
            : base("name=myContex")
        {
            // Disable proxy creation as this messes up the data service.
            //this.Configuration.ProxyCreationEnabled = false;

            //// Create Northwind if it doesn't already exist.
            


            //Database.SetInitializer<MyContext>(new CreateDatabaseIfNotExists<MyContext>());
            Database.SetInitializer<MyContext>(new DropCreateDatabaseAlways<MyContext>());

           

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        
    }
}

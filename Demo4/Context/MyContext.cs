using Demo4.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=myContext")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<MyContext>());
        }
        public DbSet<Category> Categoris { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Entity.Maping.CategoryMap());
            modelBuilder.Configurations.Add(new Entity.Maping.ProductMap());

          
        }
    }
}

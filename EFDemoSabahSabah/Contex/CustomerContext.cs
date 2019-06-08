using EFDemoSabahSabah.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoSabahSabah.Contex
{
    class MyContext:DbContext
    {
        public MyContext():base("name=myContext")
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Note> Notes { get; set; }
    }
}

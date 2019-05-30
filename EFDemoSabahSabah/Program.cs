using EFDemoSabahSabah.Contex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoSabahSabah
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var con = new CustomerContext())
            {
                con.Customers.Add(new Entity.Customer() { Name = "abc" });
                con.SaveChanges();
                foreach (var item in con.Customers)
                {
                    Console.WriteLine($"{item.Name}");
                }
            }


        }
    }
}

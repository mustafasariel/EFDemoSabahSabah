using CodeFirstFluentApiDemo.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFluentApiDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var c =new NorthwindContext())
            {


                c.Customers.Add(new Entities.Customer
                {
                    // CustomerID = 4,
                    CityCode = "34",
                    CompanyName = "gkCredit",
                    ContactName = "mustafa sarıel",
                    Country = "Türkiye",
                    CreateDate = DateTime.Now,
                    Orders = new List<Entities.Order>()
                }
                );

                c.SaveChanges();


                foreach (var item in c.Customers)
                {
                    Console.WriteLine(item.ContactName);
                }
            }
        }
    }
}

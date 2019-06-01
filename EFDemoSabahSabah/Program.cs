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
            //dataEntry();

            // list();


            using (var con =new MyContext())
            {
                var c1 = con.Customers.Where(x => x.Id == 2);
                var c2 = con.Customers.Find(2);

                Console.WriteLine($"c1 :{c1}");
                Console.WriteLine($"c2 :{c2}");

            }
            Console.ReadLine();

        }

        private static void list()
        {
            using (var con = new MyContext())
            {
                Console.WriteLine("Customer");

                var customers = con.Customers.ToList();

                foreach (var item in customers)
                {
                    Console.WriteLine(item.Name);

                }
            }
        }

        private static void dataEntry()
        {
            using (var con = new MyContext())
            {
                con.Customers.Add(new Entity.Customer() { Name = "Kerem" });
                con.Customers.Add(new Entity.Customer() { Name = "Emirhan" });
                con.Customers.Add(new Entity.Customer() { Name = "Serpil" });
                con.Customers.Add(new Entity.Customer() { Name = "Mustafa" });


                con.Notes.Add(new Entity.Note { Name = "yemek", Description = "iftar hazırlığı" });

                con.Notes.Add(new Entity.Note { Name = "iş", Description = "code first" });

                con.Notes.Add(new Entity.Note { Name = "ingilizce", Description = "busuu" });

                con.SaveChanges();

            }
        }
    }
}

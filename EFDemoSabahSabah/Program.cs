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
            dataEntry1();

            // list();
             dataEntryNotes();

            //using (var con = new MyContext())
            //{
            //    var c1 = con.Customers.Where(x => x.Id == 2).FirstOrDefault();
            //    var c2 = con.Customers.Find(2);

            //    Console.WriteLine($"c1 :{c1}");
            //    Console.WriteLine($"c2 :{c2}");

            //}

            //list2();
            // deleteNote(9);

           

           // list2();
     

           // updateCustomer(8);
            Console.ReadLine();

        }

        static void updateCustomer(int id)
        {
            using (var con = new MyContext())
            {
                var customer = con.Customers.Find(id);
                Console.WriteLine($"{customer} güncellenecek");

                customer.Name = "Mahir";
                con.SaveChanges();
                customer = con.Customers.Find(id);
                Console.WriteLine($" güncellendi");
                Console.WriteLine($"{customer}");
            }
        }
        static void deleteNote(int id)
        {
            using (var con = new MyContext())
            {
                var note = con.Notes.Find(id);
                if (note != null)
                {
                    con.Notes.Remove(note);
                    Console.WriteLine($"{note} siliniyor");
                    con.SaveChanges();
                }
            }
        }


        private static void list2()
        {
            using (var con = new MyContext())
            {
                Console.WriteLine("Customer");

                var quary = con.Customers.Include("Notes");
                var customers = quary.ToList();

                foreach (var item in customers)
                {
                    Console.WriteLine($"ID {item.Id} isim :{item.Name}");

                    var lst = item.Notes.ToList();
                    foreach (var n in lst)
                    {
                        Console.WriteLine($"    Not: {n.Id} {n.Name} {n.Description}");
                    }

                }
            }
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

        private static void dataEntry1()
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

        private static void dataEntryNotes()
        {
            using (var con = new MyContext())
            {
                var c1= con.Customers.Where(x => x.Id == 3).FirstOrDefault();


                c1.Notes.Add(new Entity.Note { Name = "ef çalışmaya devam" });
                c1.Notes.Add(new Entity.Note { Name = "linq çalışmaya devam" });

                con.SaveChanges();

            }
        }
    }
}

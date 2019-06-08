using Demo5.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contex=new MyContext())
            {
                contex.Categories.Add(new Entity.Category() { CategoryName = "Elektronik" });
                contex.Categories.Add(new Entity.Category() { CategoryName = "Gıda" });
                contex.Categories.Add(new Entity.Category() { CategoryName = "Mutfak" });
                contex.Categories.Add(new Entity.Category() { CategoryName = "Kırtasiye" });
                contex.SaveChanges();


                foreach (var item in contex.Categories)
                {
                    Console.WriteLine(item.CategoryName);
                }

            }
        }
    }
}

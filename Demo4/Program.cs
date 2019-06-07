using Demo4.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var c = new MyContext())
            {

                c.Categoris.Add(new Entity.Category()
                {

                    Name = "Elektirk",
                    CreateDate = DateTime.Now,
                    CreateBy = "msariel",
                    UpdateBy = "msariel",
                    UpdateDate = DateTime.Now
                    
                    

                });

                c.SaveChanges();

                foreach (var item in c.Categoris)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}

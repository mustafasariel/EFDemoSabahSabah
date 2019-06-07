using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfDemo3.EF;
using EfDemo3.Entity;
namespace EfDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var con = new EfDemo3.EF.MyContext())
                {
                    con.Categories.Add(new Category { CategoryName = "Elektornik" });
                    con.SaveChanges();
                }
            }
            catch (Exception)
            {
                using (var con = new EfDemo3.EF.MyContext())
                {
                    con.Categories.Add(new Category { CategoryName = "Elektornik" });
                    con.SaveChanges();
                }
            }
           
        }
    }
}

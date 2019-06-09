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
            linq_004();

            Console.ReadLine();
        }

        private static void linq_003()
        {
            using (var c =new MyContext())
            {
                var result = from p in c.Products
                            where p.isStock == false && p.UnitPrice < 10
                            select p;

                foreach (var item in result.ToList())
                {
                    Console.WriteLine(item.ProductName);
                }
            }
        }

        static void linq_005()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortDigits = digits.Where((digit, index) => digit.Length < index);

            Console.WriteLine("Short digits:");
            foreach (var d in shortDigits)
            {
                Console.WriteLine("The word {0} is shorter than its value.", d);
            }
        }


        static void linq_004()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortDigits = digits.Where((a, b) => a.Length < b);

            Console.WriteLine("Short digits:");
            foreach (var d in shortDigits)
            {
                Console.WriteLine(d);
            }
        }

        private static void linq_002()
        {
            using (var contex = new MyContext())
            {
                var lstProduct = contex.Products.ToList();

                var stock_trues = (from p in lstProduct
                                   where p.isStock == true
                                   select new { name = p.ProductName }).ToList();

                Console.WriteLine($"stock count:{stock_trues.Count()}");
                foreach (var item in stock_trues)
                {
                    Console.WriteLine(item.name);
                }

            }
        }
    }
}

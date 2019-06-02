using CodeFirstNorthwind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NortwindDenemeleri
{
    class Program
    {
        static void Main(string[] args)
        {

            //fillProduct();
            ListProductSummary();

            Console.ReadLine();
        }


        static void ListProductSummary()
        {
            using (var con = new NorthwindContext())
            {
                var lst = from p in con.Products
                          select new { Ad = p.ProductName, Fiyat = p.UnitPrice }; // anonim type


                foreach (var item in lst)
                {
                    Console.WriteLine($"{item.Ad} - {item.Fiyat}");
                }
            }
        }
        static void fillProduct()
        {
            using (var contex=new NorthwindContext())
            {
                for (int i = 0; i < 100; i++)
                {
                    contex.Products.Add(new Product
                    {
                        ProductName = FakeData.TextData.GetAlphabetical(5),
                        UnitPrice = FakeData.NumberData.GetNumber(10, 100),
                        UnitsInStock = (short)FakeData.NumberData.GetNumber(100),
                        Discontinued = FakeData.BooleanData.GetBoolean(),
                        ReorderLevel = (short)FakeData.NumberData.GetNumber(1, 5),
                        UnitsOnOrder = (short)FakeData.NumberData.GetNumber(20)

                    });
                }

                contex.SaveChanges();
               

            }
        }


    }
}

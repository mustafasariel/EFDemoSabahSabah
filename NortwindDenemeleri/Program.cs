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
            //ListProductSummary();

            //groupFonk1();
            // groupFonk2();
            //groupOrderByDescending();
            ListProductSummaryOrderby();


            Console.ReadLine();
        }

        static void groupOrderByDescending()
        {
            using (var con = new NorthwindContext())
            {
                var result = from p in con.Products
                             group p by new { p.ReorderLevel, p.Discontinued }
                             into urun
                             orderby urun.Key.ReorderLevel descending
                             select new { Level = urun.Key.ReorderLevel, urun.Key.Discontinued, Adet = urun.Count() };

                foreach (var item in result)
                {
                    Console.WriteLine($"{item.Level},{item.Discontinued} ,{item.Adet}");
                }
            }
        }

        static void groupOrderBy()
        {
            using (var con = new NorthwindContext())
            {
                var result = from p in con.Products
                             group p by new { p.ReorderLevel, p.Discontinued }
                             into urun
                             orderby urun.Key.ReorderLevel ascending
                             select new { Level = urun.Key.ReorderLevel, urun.Key.Discontinued, Adet = urun.Count() };

                foreach (var item in result)
                {
                    Console.WriteLine($"{item.Level},{item.Discontinued} ,{item.Adet}");
                }
            }
        }
        static void groupFonk2()
        {
            using (var con = new NorthwindContext())
            {
                var result = from p in con.Products
                             group p by new { p.ReorderLevel, p.Discontinued }
                             into urun
                             orderby urun.Key.ReorderLevel
                             select new { Level = urun.Key.ReorderLevel, urun.Key.Discontinued, Adet = urun.Count() };

                foreach (var item in result)
                {
                    Console.WriteLine($"{item.Level},{item.Discontinued} ,{item.Adet}");
                }
            }
        }

        static void groupFonk1()
        {
            using (var con = new NorthwindContext())
            {
                var result = from p in con.Products
                             group p by p.ReorderLevel
                             into grup
                             select new { Level = grup.Key, Adet = grup.Count() };

                foreach (var item in result)
                {
                    Console.WriteLine($"{item.Level}, {item.Adet}");
                }
            }
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

        static void ListProductSummaryOrderby()
        {
            using (var con = new NorthwindContext())
            {
                var lst = from p in con.Products
                          orderby p.UnitPrice
                          select new { Ad = p.ProductName, Fiyat = p.UnitPrice };
                          
                         
                          // anonim type


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

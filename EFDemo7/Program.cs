using EFDemo7.Entity;
using EFDemo7.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo7
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ShopUnitOfWork worker = new ShopUnitOfWork())
            {
                Category computerBook = new Category { Title = "Computer Books" };
                worker.CategoryRepository.Insert(computerBook);
                computerBook.Products = new List<Product> {
                    new Product { Title = "Advanced NoSQL", Quantity = 1, UnitPrice = 34.59M },
                    new Product { Title = "NHibernate in Action", Quantity = 5, UnitPrice = 29.99M },
                    new Product { Title = "Unleashed Delphi 2.0", Quantity = 3, UnitPrice = 9.99M }
                };
                Category cookBook = new Category { Title = "Cook Books" };
                worker.CategoryRepository.Insert(cookBook);
                cookBook.Products = new List<Product> {
                new Product()
                    {
                        Title = "Italian Kitchen", Quantity = 20, UnitPrice = 12 }
                    };
                worker.CategoryRepository.Insert(cookBook);
                worker.Save();
                var books = worker.ProductRepository.Select(p => p.CategoryID == computerBook.CategoryID);
                foreach (var book in books)
                {
                    Console.WriteLine("{0} {1} {2}", book.Title, book.UnitPrice, book.Quantity);
                }
            }
        }
    }
}

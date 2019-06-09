using Demo5.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5.EF
{
    public class MyContextInitializer : DropCreateDatabaseAlways<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            context.Categories.Add(new Entity.Category() { CategoryName = "Elektronik" });
            context.Categories.Add(new Entity.Category() { CategoryName = "Gıda" });
            context.Categories.Add(new Entity.Category() { CategoryName = "Mutfak" });
            context.Categories.Add(new Entity.Category() { CategoryName = "Kırtasiye" });
            context.SaveChanges();

            List<Category> categories = context.Categories.ToList();

            IList<Product> products = new List<Product>();

            for (int i = 0; i < 1000; i++)
            {
                context.Products.Add(new Product
                {
                    Category = categories[new Random().Next(0, categories.Count - 1)],
                    isStock = FakeData.BooleanData.GetBoolean(),
                    ProductName = FakeData.NameData.GetCompanyName(),
                    Stock = FakeData.NumberData.GetNumber(0, 100),
                    UnitPrice = FakeData.NumberData.GetNumber(0, 1000),
                });
                 
                context.SaveChanges();
            }

            base.Seed(context);
        }
    }
}
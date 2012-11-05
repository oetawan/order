using Order.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Data.SampleData
{
    public class OrderDatabaseInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<OrderDbContext>
    {
        protected override void Seed(OrderDbContext context)
        {
            Category smartphone = new Model.Category { Name = "Smartphone" };
            Category laptop = new Model.Category { Name = "Smartphone" };

            Product iphone5 = new Product { Barcode = "IP5", Name = "iPhone 5", Category = smartphone, Price = 7500000 };
            Product iphone4s = new Product { Barcode = "IP4S", Name = "iPhone 4S", Category = smartphone, Price = 5000000 };
            Product galaxys3 = new Product { Barcode = "GS3", Name = "Samsung Galaxy S3", Category = smartphone, Price = 6000000 };

            Product macbookpro = new Product { Barcode = "MPRO13", Name = "Macbook Pro 13.3", Category = laptop, Price = 10000000 };
            Product lenovo = new Product { Barcode = "LNV1", Name = "Lenovo ThinkPad Edge E330", Category = laptop, Price = 6500000 };
            Product hpenvy = new Product { Barcode = "ENVY1", Name = "HP Envy 4", Category = laptop, Price = 4000000 };

            context.Categories.Add(smartphone);
            context.Categories.Add(laptop);
            context.Products.Add(iphone5);
            context.Products.Add(iphone4s);
            context.Products.Add(galaxys3);
            context.Products.Add(macbookpro);
            context.Products.Add(lenovo);
            context.Products.Add(hpenvy);

            context.SaveChanges();
        }
    }
}
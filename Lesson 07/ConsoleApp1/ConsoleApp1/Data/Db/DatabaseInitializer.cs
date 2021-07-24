using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ConsoleApp1.Data.Db.Entities;

namespace ConsoleApp1.Data.Db
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);

            context.Products.AddRange(new Product[]
            {
                new Product { Name = "Product 1", Price = 200 },
                new Product { Name = "Product 2", Price = 150 },
                new Product { Name = "Product 3", Price = 290 },
                new Product { Name = "Product 4", Price = 65.7m },
                new Product { Name = "Product 5", Price = 15.3m },
                new Product { Name = "Product 6", Price = 500 },
                new Product { Name = "Product 7", Price = 900 },
            });

            context.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ConsoleApp1.Database.Entities;

namespace ConsoleApp1.Database
{
    /*
        DropCreateDatabaseAlways
        DropCreateDatabaseIfModelChanges
        CreateDatabaseIfNotExists
     */
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext ctx)
        {
            base.Seed(ctx);

            var category1 = new Category
            {
                Name = "Category 1"
            };

            var category2 = new Category
            {
                Name = "Category 2"
            };

            var prod1 = new Product
            {
                Title = "Product 1",
                Description = "Some product 1",
                Price = 100,
                Category = category1
            };

            var prod2 = new Product
            {
                Title = "Product 2",
                Description = "Some product 2",
                Price = 100,
                Category = category2
            };

            var prod3 = new Product
            {
                Title = "Product 3",
                Description = "Some product 3",
                Price = 100,
                Category = category1
            };

            var prod4 = new Product
            {
                Title = "Product 4",
                Description = "Some product 4",
                Price = 100,
                Category = category2
            };

            ctx.Products.Add(prod1);
            ctx.Products.Add(prod2);
            ctx.Products.Add(prod3);
            ctx.Products.Add(prod4);

            ctx.SaveChanges();
        }
    }
}

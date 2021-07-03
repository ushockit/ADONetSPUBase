using ConsoleApp1.Business.Services;
using ConsoleApp1.Database;
using ConsoleApp1.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductsService productsService = new ProductsService();
            CategoriesService categoriesService = new CategoriesService();
            Category category = categoriesService.GetCategory(1);
            Product newProduct = new Product
            {
                CategoryId = category.Id,
                Description = "Some a new product description",
                Price = 200,
                Title = "New product"
            };

            productsService.CreateProduct(newProduct);
            
            // productsService.RemoveProduct(1);
            var products = productsService.GetAllProducts();
            // var products = productsService.GetProductsByCategoryId(1);
            ;

            Console.Read();
        }
    }
}

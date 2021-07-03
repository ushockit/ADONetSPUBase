using ConsoleApp1.Database;
using ConsoleApp1.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApp1.Business.Services
{
    public class ProductsService
    {
        public List<Product> GetAllProducts()
        {
            List<Product> products = null;
            using (var ctx = DatabaseContext.Create())
            {
                products = ctx.Products
                    .Include(p => p.Category)
                    .ToList();
            }
            return products;
        }
        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            List<Product> products = null;
            using (var ctx = DatabaseContext.Create())
            {
                products = ctx.Products.Where(p => p.CategoryId == categoryId).ToList();
            }
            return products;
        }

        public void RemoveProduct(int id)
        {
            using (var ctx = DatabaseContext.Create())
            {
                var product = ctx.Products.FirstOrDefault(p => p.Id == id);
                // ctx.Products.Remove(product);
                ctx.Entry(product).State = EntityState.Deleted;
                ctx.SaveChanges();
            }
        }

        public void CreateProduct(Product product)
        {
            using (var ctx = DatabaseContext.Create())
            {
                ctx.Products.Add(product);
                ctx.SaveChanges();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (var ctx = DatabaseContext.Create())
            {
                var updatedProduct = ctx.Products.FirstOrDefault(p => p.Id == product.Id);
                updatedProduct.Title = product.Title;
                updatedProduct.Description = product.Description;
                updatedProduct.CategoryId = product.CategoryId;
                updatedProduct.Price = product.Price;

                ctx.Entry(updatedProduct).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}

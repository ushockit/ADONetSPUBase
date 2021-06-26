using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Store.UI.Database.Entities;

namespace Store.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CONNECTION_STRING = @"Data Source=DESKTOP-HRGSSEH\SQLEXPRESS;Initial Catalog=shopDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                // Select One To One
                // var categories = connection.Query<Category>("SELECT * FROM Categories").ToList();
                // string sql = "SELECT * FROM Products prod INNER JOIN Categories cat ON prod.categoryId = cat.id";

                //var products = connection.Query<Product, Category, Product>(sql, (prod, cat) =>
                //{
                //    prod.Category = cat;
                //    return prod;
                //});


                // SELECT One To Many
                //string sqlProducts = "SELECT * FROM Products prod INNER JOIN Categories cat ON prod.categoryId = cat.id";
                //var products = connection.Query<Product, Category, Product>(sqlProducts, (prod, cat) =>
                //{
                //    prod.Category = cat;
                //    return prod;
                //});
                //var grouped = products.GroupBy((prod) => prod.CategoryId);

                //string sqlCategories = "SELECT * FROM Categories";

                //var categories = connection.Query<Category>(sqlCategories).Select(cat =>
                //{
                //    var prods = grouped.FirstOrDefault(list => list.Key == cat.Id);
                //    if (prods != null)
                //    {
                //        cat.Products = prods.ToList();
                //    }
                //    return cat;
                //}).ToList();


                //connection.Execute("INSERT INTO Products VALUES (@name, @price, @categoryId)", new
                //{
                //    name = "Product 6",
                //    price = 500,
                //    categoryId = 5
                //});
                ;
            }

            Console.Read();
        }
    }
}

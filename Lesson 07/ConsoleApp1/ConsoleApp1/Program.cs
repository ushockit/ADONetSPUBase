using ConsoleApp1.Data.Db;
using ConsoleApp1.Data.Db.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var ctx = DatabaseContext.Create())
            {
                var products = ctx.Products.AsNoTracking().ToList();
                ;
                // вызов функции
                // var prod = ctx.Database.SqlQuery<Product>("SELECT * FROM GetProductWithMaxPrice()").FirstOrDefault();
                // вызов процедуры
                //ctx.Database.ExecuteSqlCommand(
                //    "sp_CreateNewProduct @name, @price",
                //    new SqlParameter("@name", "Some product name"),
                //    new SqlParameter("@price", 150.4m));

                Console.WriteLine("Success");
            }

            Console.Read();
        }
    }
}

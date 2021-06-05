using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{ConfigurationManager.AppSettings["title"]}");

            string connectionString = ConfigurationManager.AppSettings["connectionString"];


            // подключение к БД
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // открытие подключения
                connection.Open();
                Console.WriteLine("Success connection!");


                #region SELECT
                //SqlCommand comm = new SqlCommand
                //{
                //    CommandText = "SELECT * FROM Products",
                //    Connection = connection
                //};

                // выполнение запроса
                //using (SqlDataReader reader = comm.ExecuteReader())
                //{
                //    if (reader.HasRows)
                //    {
                //        Console.WriteLine("Has data");
                //        List<Product> products = new List<Product>();
                //        // цикличное чтение данных
                //        while (reader.Read())
                //        {
                //            try
                //            {
                //                int id = reader.GetInt32(0);
                //                string productName = reader.GetString(1);
                //                int? supplierId = reader.GetValue(2) as int?;
                //                int? categoryId = reader.GetValue(3) as int?;
                //                string quantityPerUnit = reader.GetString(4);
                //                decimal unitPrice = reader.GetDecimal(5);

                //                products.Add(new Product
                //                {
                //                    Id = id,
                //                    Name = productName,
                //                    SupplierId = supplierId,
                //                    CategoryId = categoryId,
                //                    QuantityPerUnit = quantityPerUnit,
                //                    UnitPrice = unitPrice
                //                });
                //            }
                //            catch (SqlNullValueException ex)
                //            {
                //                ;
                //            }
                //        }
                //        ;
                //    }
                //    else
                //    {
                //        Console.WriteLine("Table is empty");
                //    }
                //}
                #endregion

                #region INSERT
                SqlCommand comm = new SqlCommand
                {
                    CommandText = "INSERT INTO Products VALUES (@name, @supplierId, @categoryId, @quantityPerUnit, @unitPrice, @unitsInStock, @unitsOnOrder, @reorderedLevel, @discountinued)",
                    Connection = connection
                };

                comm.Parameters.AddWithValue("@name", "Test test");
                comm.Parameters.AddWithValue("@supplierId", 2);
                comm.Parameters.AddWithValue("@categoryId", 1);
                comm.Parameters.AddWithValue("@quantityPerUnit", "40 pies");
                comm.Parameters.AddWithValue("@unitPrice", 1);
                comm.Parameters.AddWithValue("@unitsInStock", 1);
                comm.Parameters.AddWithValue("@unitsOnOrder", 1);
                comm.Parameters.AddWithValue("@reorderedLevel", 1);
                comm.Parameters.AddWithValue("@discountinued", 1);

                int count = comm.ExecuteNonQuery();
                Console.WriteLine($"Count = {count}");
                #endregion

            }



            Console.Read();
        }
    }
}

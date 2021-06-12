using System;
using System.Collections.Generic;
using System.Configuration;
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
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Success connection");


                //SqlCommand comm = new SqlCommand
                //{
                //    CommandText = "SELECT * FROM Orders WHERE ShipName = @shipName",
                //    Connection = connection
                //};

                //SqlParameter param = new SqlParameter
                //{
                //    ParameterName = "@shipName",
                //    Value = "La maison d'Asie",
                //};
                //comm.Parameters.Add(param);

                //var reader = comm.ExecuteReader();
                //if (reader.HasRows)
                //{

                //}
                //else
                //{
                //    Console.WriteLine("Not exists");
                //}


                /*SqlCommand comm = new SqlCommand
                {
                    CommandText = "SELECT COUNT(*) FROM Orders WHERE ShipName = @shipName",
                    Connection = connection
                };

                SqlParameter param = new SqlParameter
                {
                    ParameterName = "@shipName",
                    Value = "La maison d'Asie",
                };
                comm.Parameters.Add(param);

                var result = comm.ExecuteScalar();
                */

                //SqlCommand comm = new SqlCommand
                //{
                //    CommandText = "[Sales by Year]",
                //    Connection = connection,
                //    CommandType = System.Data.CommandType.StoredProcedure
                //};

                //SqlParameter param1 = new SqlParameter
                //{
                //    Value = "1996-01-01",
                //    SqlDbType = System.Data.SqlDbType.DateTime,
                //    ParameterName = "@Beginning_Date"
                //};

                //SqlParameter param2 = new SqlParameter
                //{
                //    Value = "1997-12-31",
                //    SqlDbType = System.Data.SqlDbType.DateTime,
                //    ParameterName = "@Ending_Date"
                //};

                //comm.Parameters.Add(param1);
                //comm.Parameters.Add(param2);

                //var reader = comm.ExecuteReader();

                //if (reader.HasRows)
                //{
                //    while (reader.Read())
                //    {
                //        for(int i = 0; i < reader.FieldCount; i++)
                //        {
                //            Console.Write($"{reader.GetValue(i)}\t");
                //        }
                //        Console.WriteLine();
                //    }
                //}


                SqlCommand comm = new SqlCommand
                {
                    CommandText = "sp_GetMinMaxOrderDates",
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                // определение выходных параметров
                SqlParameter minDateParam = new SqlParameter
                { 
                    SqlDbType = System.Data.SqlDbType.DateTime,
                    Direction = System.Data.ParameterDirection.Output,
                    ParameterName = "@minDate"
                };
                SqlParameter maxDateParam = new SqlParameter
                {
                    SqlDbType = System.Data.SqlDbType.DateTime,
                    Direction = System.Data.ParameterDirection.Output,
                    ParameterName = "@maxDate"
                };
                //comm.Parameters.Add(minDateParam);
                //comm.Parameters.Add(maxDateParam);
                comm.Parameters.AddRange(new SqlParameter[] 
                { 
                    minDateParam, 
                    maxDateParam 
                });

                comm.ExecuteNonQuery();

                Console.WriteLine(minDateParam.Value);
                Console.WriteLine(maxDateParam.Value);
                
                
            }

            Console.Read();
        }
    }
}

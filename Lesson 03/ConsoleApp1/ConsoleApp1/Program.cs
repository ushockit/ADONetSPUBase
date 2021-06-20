using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext db = new LibraryContext(@"Data Source=DESKTOP-HRGSSEH\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            //if (db.DatabaseExists())
            //{
            //    db.DeleteDatabase();
            //}
            //db.CreateDatabase();

            if (!db.DatabaseExists())
            {
                db.CreateDatabase();
            }

            #region SELECT
            //Table<Genre> genresTable = db.GetTable<Genre>();
            //var genres = genresTable.ToList();
            //;
            #endregion

            #region INSERT
            //Table<Genre> genresTable = db.GetTable<Genre>();
            //genresTable.InsertOnSubmit(new Genre { Name = "Художественная литература" });
            //db.SubmitChanges();
            //Console.WriteLine("Success");
            #endregion

            #region DELETE
            //Table<Genre> genresTable = db.GetTable<Genre>();

            //// НЕ ПРАВИЛЬНО!!!!
            ////genresTable.ToList().FirstOrDefault(g => g.Name.Equals("Genre 1"))
            //// ПРАВИЛЬНО!!!
            //Genre genre = genresTable.FirstOrDefault(g => g.Name.Equals("Genre 1"));

            //genresTable.DeleteOnSubmit(genre);
            //db.SubmitChanges();

            #endregion

            #region UPDATE

            //Table<Genre> genres = db.GetTable<Genre>();

            //Genre genre = genres.FirstOrDefault(g => g.Id == 6);
            //genre.Name = "Updated genre";

            //db.SubmitChanges();

            #endregion

        }
    }
}

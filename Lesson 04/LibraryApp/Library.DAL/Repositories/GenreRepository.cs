using Library.DAL.Database;
using Library.DAL.Database.DbConnection;
using Library.DAL.Entities;
using Library.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Repositories
{
    public class GenreRepository : IRepository<Genre>
    {
        LibraryContext ctx;
        public GenreRepository(LibraryContext context)
        {
            ctx = context;
        }
        public void Create(Genre entity)
        {
            //using (var connection = DbConnectionFactory.Factory.GetSqlConnection())
            //{
            //    connection.Open();
            //    var command = new SqlCommand
            //    {
            //        Connection = connection,
            //        CommandText = "INSERT INTO Genres VALUES (@name)"
            //    };
            //    command.Parameters.AddWithValue("@name", entity.Name);
            //    command.ExecuteNonQuery();
            //}
            ctx.GetTable<Genre>().InsertOnSubmit(entity);
        }

        public void Delete(int id)
        {
            //using (var connection = DbConnectionFactory.Factory.GetSqlConnection())
            //{
            //    connection.Open();
            //    var command = new SqlCommand
            //    {
            //        Connection = connection,
            //        CommandText = "DELETE FROM Genres WHERE id = @id"
            //    };
            //    command.Parameters.AddWithValue("@id", id);
            //    command.ExecuteNonQuery();
            //}
        }

        public Genre Get(int id)
        {
            //Genre genre = null;
            //using (var connection = DbConnectionFactory.Factory.GetSqlConnection())
            //{
            //    connection.Open();
            //    var command = new SqlCommand
            //    {
            //        Connection = connection,
            //        CommandText = "SELECT * FROM Genres WHERE id = @id"
            //    };
            //    command.Parameters.AddWithValue("@id", id);
            //    var reader = command.ExecuteReader();

            //    if (reader.HasRows && reader.Read())
            //    {
            //        genre = new Genre();
            //        genre.Id = reader.GetInt32(0);
            //        genre.Name = reader.GetString(1);
            //    }
            //}
            //return genre;

            return ctx.GetTable<Genre>().FirstOrDefault(g => g.Id == id);
        }

        public List<Genre> GetAll()
        {
            List<Genre> genres = new List<Genre>();
            //using (var connection = DbConnectionFactory.Factory.GetSqlConnection())
            //{
            //    connection.Open();
            //    var command = new SqlCommand
            //    {
            //        Connection = connection,
            //        CommandText = "SELECT * FROM Genres"
            //    };
            //    var reader = command.ExecuteReader();

            //    if (reader.HasRows)
            //    {
            //        while (reader.Read())
            //        {
            //            genres.Add(new Genre
            //            {
            //                Id = reader.GetInt32(0),
            //                Name = reader.GetString(1)
            //            });
            //        }
            //    }
            //}
            //return genres;

            return ctx.GetTable<Genre>().ToList();
        }

        public void Update(Genre genre)
        {
            //using (var connection = DbConnectionFactory.Factory.GetSqlConnection())
            //{
            //    connection.Open();
            //    var command = new SqlCommand
            //    {
            //        Connection = connection,
            //        CommandText = "UPDATE Genres SET name = @name WHERE id = @id"
            //    };
            //    command.Parameters.AddWithValue("@name", entity.Name);
            //    command.Parameters.AddWithValue("@id", entity.Id);
            //    command.ExecuteNonQuery();
            //}

            Genre entity = ctx.Genres.FirstOrDefault(g => g.Id == genre.Id);
            entity.Name = genre.Name;
        }
    }
}

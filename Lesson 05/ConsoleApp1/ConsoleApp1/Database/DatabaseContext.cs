using ConsoleApp1.Database.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        static DatabaseContext()
        {
            // Установка инициализатора БД
            System.Data.Entity.Database.SetInitializer(new DatabaseInitializer());
        }

        private DatabaseContext() : base("DefaultConnection")
        {

        }

        public static DatabaseContext Create()
        {
            return new DatabaseContext();
        }
    }
}

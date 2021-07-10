using ConsoleApp1.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        static DatabaseContext()
        {
            Database.SetInitializer(new DatabaseInitializer());
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

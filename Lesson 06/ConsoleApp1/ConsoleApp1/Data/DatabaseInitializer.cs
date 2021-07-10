using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ConsoleApp1.Data.Entities;

namespace ConsoleApp1.Data
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);

            var acc = new Account
            {
                Login = "vasya",
                Password = "123456",
                Email = "vasya@gmail.com",
                User = new User
                {
                    FirstName = "Vasya",
                    LastName = "Pupkin",
                    MiddleName = "Stepanovich",
                    Birth = new DateTime(1990, 10, 10)
                }
            };
            context.Accounts.Add(acc);
            context.SaveChanges();
        }
    }
}

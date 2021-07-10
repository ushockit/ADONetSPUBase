using ConsoleApp1.Data;
using ConsoleApp1.Data.Entities;
using ConsoleApp1.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account acc = null;
            //using (var ctx = DatabaseContext.Create())
            //{
            //    var accs = ctx.Accounts.ToList();
            //    acc = accs.First();
            //}
            //var user = acc.User;
            AccountsRepository accountsRepository = new AccountsRepository();
            var accs = accountsRepository.GetAll();
            ;
        }
    }
}

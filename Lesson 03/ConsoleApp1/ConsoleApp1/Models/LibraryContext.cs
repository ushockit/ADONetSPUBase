using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class LibraryContext : DataContext
    {
        public Table<Genre> Genres { get; set; }
        public LibraryContext(string fileOrServerOrConnection) : base(fileOrServerOrConnection)
        {
        }
    }
}

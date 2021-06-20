using Library.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Database
{
    public class LibraryContext : DataContext
    {
        public Table<Genre> Genres { get; set; }
        public Table<Author> Authors { get; set; }
        public Table<Book> Books { get; set; }
        public LibraryContext(string fileOrServerOrConnection) : base(fileOrServerOrConnection)
        {

        }
    }
}

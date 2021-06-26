using Library.DAL.Database;
using Library.DAL.Database.DbConnection;
using Library.DAL.Entities;
using Library.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private LibraryContext ctx = DbConnectionFactory.Factory.GetLibraryContextConnection();

        private GenreRepository genreRepository;
        public IRepository<Genre> GenreRepository
            => genreRepository ?? (genreRepository = new GenreRepository(ctx));

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    ctx.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            ctx.SubmitChanges();
        }
    }
}

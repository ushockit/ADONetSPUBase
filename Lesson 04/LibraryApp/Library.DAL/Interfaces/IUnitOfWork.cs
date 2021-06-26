using Library.DAL.Entities;
using Library.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Genre> GenreRepository { get; }

        void Save();
    }
}

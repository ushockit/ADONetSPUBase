using ConsoleApp1.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data.Repositories
{
    public interface IRepository<TKey, TValue> : IDisposable
        where TKey : struct
        where TValue : BaseEntity<TKey>
    {
        IEnumerable<TValue> GetAll();
        void Save();
    }
}

using ConsoleApp1.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data.Repositories
{
    public abstract class BaseRepository<TKey, TValue> : IRepository<TKey, TValue>
        where TKey : struct
        where TValue : BaseEntity<TKey>
    {
        protected DatabaseContext context;
        protected DbSet<TValue> Table => context.Set<TValue>();
        public BaseRepository()
        {
            context = DatabaseContext.Create();
        }
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual IEnumerable<TValue> GetAll()
        {
            //context.Set<T>()
            return Table.ToList();
        }

        public void Save() => context.SaveChanges();
    }
}

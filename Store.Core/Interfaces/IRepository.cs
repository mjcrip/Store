using System.Collections.Generic;
using System.Linq;

namespace Store.Core.Interfaces
{
    public interface IRepository<T>
    {
        IQueryable<T> AsQueryable();
        void Insert(T entity);
        void InsertRange(List<T> entity);
        void Delete(int id);
        int SaveChanges();
        T Find(params object[] keyValues);
        void Dispose();
    }
}

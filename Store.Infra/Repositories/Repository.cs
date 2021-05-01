using Store.Core.Interfaces;
using Store.Infra.Shared;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Infra.Repositories
{
    public class Repository<T> : IRepository<T> where T : EntityContext
    {
        private readonly EntityContext _dbContext;

        public Repository(EntityContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> AsQueryable()
        {
            return this.Entities.AsQueryable();
        }

        public void Delete(int id)
        {
            var entity = Find(id);
            this.Entities.Remove(entity);
        }

        public T Find(params object[] keyValues)
        {
            return this.Entities.Find(keyValues);
        }

        public void Insert(T entity)
        {
            this.Entities.Add(entity);
        }
        public void Update(T entity, bool isModified = false)
        {
            if (isModified)
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
            }
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void InsertRange(List<T> entity)
        {
            this.Entities.AddRange(entity);
        }

        private DbSet<T> Entities
        {
            get
            {
                return _dbContext.Set<T>();
            }
        }
    }
}

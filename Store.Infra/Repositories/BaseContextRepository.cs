﻿using Store.Core.Base;
using Store.Core.Interfaces;
using Store.Infra.Shared;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Store.Infra.Repositories
{
    public class BaseContextRepository<TContext> : IEntityContextRepository<IEntityContext>
        where TContext : EntityContext
    {
        private TContext _db;

        public BaseContextRepository(TContext context)
        {
            _db = context;
        }

        public ContextNames Name { get => _db.Name; }

        public IQueryable<TQuery> GetQueryable<TQuery>(List<string> includes = null) where TQuery : BaseEntity
        {
            var query = _db.Set<TQuery>().Where(x => !x.IsDeleted).AsQueryable();

            if (includes != null)
            {
                includes.ForEach(i => query = query.Include(i));
            }

            return query;
        }

        public void ExecuteSqlQuery(string sql, params string[] parameters)
        {
            _db.Database.ExecuteSqlCommand(sql, parameters);
        }

        public IQueryable<TQuery> GetQueryable<TQuery>(params string[] includes) where TQuery : BaseEntity
        {
            var query = _db.Set<TQuery>().Where(x => !x.IsDeleted).AsQueryable();
            if (includes?.Count() > 0)
            {
                includes.ToList().ForEach(i => query = query.Include(i).Where(x => x.IsDeleted == false));
            }
            return query;
        }
        public IQueryable<TQuery> GetNoTrackingQueryable<TQuery>(List<string> includes = null) where TQuery : BaseEntity
        {
            var query = _db.Set<TQuery>().Where(x => !x.IsDeleted).AsQueryable();
            if (includes != null)
            {
                includes.ForEach(i => query = query.Include(i));
            }
            return query.AsNoTracking();
        }
        public IQueryable<TQuery> GetNoTrackingQueryableWithDeleted<TQuery>(List<string> includes = null) where TQuery : BaseEntity
        {
            var query = _db.Set<TQuery>().AsQueryable();
            if (includes != null)
            {
                includes.ForEach(i => query = query.Include(i));
            }
            return query.AsNoTracking();
        }

        public int SaveChanges()
        {
            return _db.SaveChanges();
        }

        public void Insert<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            _db.Set<TEntity>().Add(entity);
        }

        public void InsertRange<TEntity>(List<TEntity> entity) where TEntity : BaseEntity
        {
            _db.Set<TEntity>().AddRange(entity);
        }
    }
}

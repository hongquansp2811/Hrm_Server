using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Hrm_Server.DbContextHrm;
using Hrm_Server.Repositories.Interfaces;

namespace Hrm_Server.Repositories
{
    public class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey> where TEntity : class
    {
        protected readonly HrmDbContext Context;
        protected readonly DbSet<TEntity> DbSet;

        public BaseRepository(HrmDbContext context)
        {
            Context = context;
            DbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public TEntity GetById(TKey id)
        {
            return DbSet.Find(id);
        }

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            DbSet.AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            DbSet.RemoveRange(entities);
        }

        public bool Any(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Any(predicate);
        }

        public int Count(Expression<Func<TEntity, bool>> predicate = null)
        {
            return predicate == null ? DbSet.Count() : DbSet.Count(predicate);
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public IQueryable<TEntity> GetQueryable()=> (IQueryable<TEntity>) this.Context.Set<TEntity>();
    }
}
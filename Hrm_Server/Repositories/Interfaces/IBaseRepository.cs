using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Hrm_Server.Repositories.Interfaces
{
    public interface IBaseRepository<TEntity, TKey> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(TKey id);
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        void SaveChanges();
        IQueryable<TEntity> GetQueryable();
    }
}
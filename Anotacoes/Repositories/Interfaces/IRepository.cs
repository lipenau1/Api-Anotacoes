using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AN.Api.Repositories.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(int id);
        void Remove(TEntity entity);
        void Remove(Guid id);
        IQueryable<TEntity> FindOut(Expression<Func<TEntity, bool>> predicate);
    }
}

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AN.Api.Services
{
    public interface IService<TEntity> : IDisposable where TEntity : class
    {
        TEntity Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> FindOut(Expression<Func<TEntity, bool>> predicate);
        void Update(TEntity obj);
        void Remove(int id);
        void Remove(Guid id);

    }
}

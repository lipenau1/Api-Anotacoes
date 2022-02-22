using AN.Api.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AN.Api.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;

        public Service(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual TEntity Add(TEntity obj)
        {
            return _repository.Add(obj);
        }

        public virtual TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual IEnumerable<TEntity> FindOut(Expression<Func<TEntity, bool>> predicate)
        {
            return _repository.FindOut(predicate);
        }

        public virtual void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public virtual void Remove(int id)
        {
            _repository.Remove(id);
        }

        public void Dispose()
        {
            _repository.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual void Remove(Guid id)
        {
            _repository.Remove(id);
        }
    }
}

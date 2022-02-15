using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AN.Api.Repositories.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Adicionar(TEntity obj);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity obj);
        void Remover(int id);
        void Remover(TEntity entity);
        IQueryable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
    }
}

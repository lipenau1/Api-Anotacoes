using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AN.Api.Services
{
    public interface IService<TEntity> : IDisposable where TEntity : class
    {
        TEntity Adicionar(TEntity obj);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
        void Atualizar(TEntity obj);
        void Remover(int id);
    }
}

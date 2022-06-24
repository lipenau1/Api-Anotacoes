using System;
using System.Threading.Tasks;

namespace AN.Api.UoW.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        Task CommitAsync();

        bool HasChanges();
    }
}

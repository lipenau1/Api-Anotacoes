using System;

namespace AN.Api.UoW.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}

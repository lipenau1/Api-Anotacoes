using AN.Api.Data;
using AN.Api.UoW.Interfaces;
using System;
using System.Threading.Tasks;

namespace AN.Api.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
        }

        public void Commit() => _context.SaveChanges();

        public Task CommitAsync() => _context.SaveChangesAsync();

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
                GC.SuppressFinalize(this);
            }
        }

        public bool HasChanges()
        {
            return _context.ChangeTracker.HasChanges();
        }

    }
}

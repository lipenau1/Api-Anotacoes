using AN.Api.Data;
using AN.Api.UoW.Interfaces;
using System;

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

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
                GC.SuppressFinalize(this);
            }
        }

    }
}

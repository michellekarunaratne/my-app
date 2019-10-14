using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerAPI.Core;
using ServerAPI.Core.Interfaces;
using ServerAPI.Infrastucture;
using ServerAPI.Persistence.Repositories;

namespace ServerAPI.Core.Domain
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly dbContext _context;

        public UnitOfWork(dbContext context)
        {
            _context = context;
            User = new UserRepository(_context);
        }
        public IUserRepository Users => throw new NotImplementedException();

        public int Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

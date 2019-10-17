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
        private UserRepository _user;

        public UnitOfWork(dbContext context)
        {
            _context = context;
        }

        public IUserRepository Users
        {
            get
            {
              if (_user == null)
              {
                _user = new UserRepository(_context);
              }

              return _user;
            }
        }

        public void Save()
        {
          _context.SaveChanges();
        }

        public void Dispose()
        {
          _context.Dispose();
        }
    }
}

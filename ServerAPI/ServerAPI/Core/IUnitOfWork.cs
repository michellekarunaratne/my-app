using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerAPI.Core.Interfaces;

namespace ServerAPI.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }

        void Save();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerAPI.Core.Domain;

namespace ServerAPI.Core.Interfaces
{
    public interface IUserRepository :IRepository<User>
    {
       

        public void AddUser(User user);
        public User FindUser(string nic);

    public void UpdateUser(User user);

    }
}

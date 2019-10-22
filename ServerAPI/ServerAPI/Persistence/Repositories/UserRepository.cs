using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerAPI.Core.Interfaces;
using ServerAPI.Persistence.Repositories;
using ServerAPI.Core.Domain;
using ServerAPI.Infrastucture;


namespace ServerAPI.Persistence.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly dbContext _userDbEntities;
        public UserRepository(dbContext context)
            : base(context)
        {
            _userDbEntities = context;
        }
        

        public void AddUser(User user)
        {
            _userDbEntities.Add(user);
        }

        public User FindUser(string nic)
        {
            User user = _userDbEntities.Find<User>(nic);
            return user;

        }

        public void UpdateUser(User user)
        {
          User oldUser = _userDbEntities.Find<User>(user.nic);
          oldUser.firstName = user.firstName;
          oldUser.lastName = user.lastName;
          oldUser.phone = user.phone;
          oldUser.email = user.email;
        }

   

    }
}

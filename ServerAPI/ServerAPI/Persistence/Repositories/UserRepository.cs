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
        public User GetUser()
        {
           return _userDbEntities.Users.Find(1);
        }

        

   

    }
}

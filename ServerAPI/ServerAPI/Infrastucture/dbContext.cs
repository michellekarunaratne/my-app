using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerAPI.Core;
using Microsoft.EntityFrameworkCore;
using ServerAPI.Core.Domain;


namespace ServerAPI.Infrastucture
{
    public class dbContext: DbContext
    {
        public dbContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<User> Users { get; set; }


    }
}

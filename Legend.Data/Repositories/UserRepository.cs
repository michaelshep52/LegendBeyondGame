using System;
using Legend.Domain.Entities;
using Legend.Domain.Interface;
using Microsoft.EntityFrameworkCore;

namespace Legend.Data.Repositories
{
    public class UserRepository : LegendRepository<User>, IUserRepository
    {
        public UserRepository(LegendContext context) : base(context)
        {

        }
    }
}
           
               



using System;
using Legend.Domain.Entities;
using Legend.Domain.Interface;

namespace Legend.Data.Repositories
{
    public class AccountRepository : LegendRepository<Account>, IAccountRepository
    {
        public AccountRepository(LegendContext context) : base(context)
        {

        }
    }
}



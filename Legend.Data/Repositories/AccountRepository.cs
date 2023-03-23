using System;
using Legend.Domain.Entities;
using Legend.Domain.Interface;
using Microsoft.EntityFrameworkCore;

namespace Legend.Data.Repositories
{
    public class AccountRepository : LegendRepository<Account>, IAccountRepository
    {
        public AccountRepository(LegendContext context) : base(context)
        {

        }

        /*public async Task<Account> GetAccountByEmail(string email) =>
            await (Task<Account>)_dbSet.Where(acc => acc.Email == email);
        */

        public async Task<Account> GetAccountByEmail(string email)
        {
            return await _dbSet.FirstOrDefaultAsync<Account>(acc => acc.Email == email);
        }
       
    }
}



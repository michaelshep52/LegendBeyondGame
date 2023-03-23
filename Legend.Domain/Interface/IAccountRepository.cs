using System;
using Legend.Domain.Entities;

namespace Legend.Domain.Interface
{
    public interface IAccountRepository : ILegendRepository<Account>
    {
       Task<Account> GetAccountByEmail(string email);
    }
}


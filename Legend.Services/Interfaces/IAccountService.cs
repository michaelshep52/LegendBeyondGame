using System;
using Legend.Domain.Entities;

namespace Legend.Services.Interfaces
{
    public interface IAccountService
    {
        Task<bool> CreateAccount(Account account);

        Task<IEnumerable<Account>> GetAllAccounts();

        Task<Account> GetAccountById(int accountId);

        Task<bool> UpdateAccount(Account account);

        Task<bool> DeleteAccount(int accountId);
    }
}


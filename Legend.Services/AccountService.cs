using System;
using System.Security.Principal;
using Legend.Data.Repositories;
using Legend.Domain.Entities;
using Legend.Domain.Interface;
using Legend.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Legend.Services
{
    public class AccountService : IAccountService
    {
        public IUnitOfWork _unitOfWork;

    public AccountService (IUnitOfWork unitOfWork)
    {
            _unitOfWork = unitOfWork;
    }

    public async Task<bool> CreateAccount(Account account)
    {
        if (account != null)
        {
            await _unitOfWork.AccountRepository.Add(account);

            var result = _unitOfWork.Save();

            if (result > 0)
                return true;
            else
                return false;
        }
        return false;
    }

    public async Task<bool> DeleteAccount(int accountId)
    {
        if (accountId > 0)
        {
            var account = await _unitOfWork.AccountRepository.GetById(accountId);
            if (account != null)
                {
                _unitOfWork.AccountRepository.Delete(account);
                var result = _unitOfWork.Save();

                if (result > 0)
                    return true;
                else
                    return false;
            }
        }
        return false;
    }

    public async Task<IEnumerable<Account>> GetAllAccounts()
    {
        var accountsList = await _unitOfWork.AccountRepository.GetAll();
        return accountsList;
    }

    public async Task<Account> GetAccountById(int accountId)
    {
        if (accountId > 0 )
        {
            var account = await _unitOfWork.AccountRepository.GetById(accountId);
            if (account != null)
            {
                return account;
            }
        }
        return null;
    }

 
    
 /*   public async Task<Account> GetAccountByEmail(string email)
    {
            var account = await _accountRepository.GetAccountByEmail(aemail);
            //_unitOfWork.AccountRepository.GetAccountByEmail(email);
           _unitOfWork.Save();
            if (account != null)
        {
            return account;
        }
    }*/



        public async Task<Account> GetAccountByEmail(string email)
         {
             if (email != null)
             {
                var account = await _unitOfWork.AccountRepository.GetAccountByEmail(email);
                 if (account != null)
                 {
                     return account;
                 }
             }
             return null;
         }

        public async Task<bool> UpdateAccount(Account account)
        {
            if (account != null)
            {
                var accountRepository = await _unitOfWork.AccountRepository.GetById(account.AccountId);
                if (accountRepository != null)
                {
                        accountRepository.AccountName = account.AccountName;
                        accountRepository.Password = account.Password;
                        accountRepository.FirstName = account.FirstName;
                        accountRepository.LastName = account.LastName;
                        accountRepository.Email = account.Email;


                        _unitOfWork.AccountRepository.Update(accountRepository);

                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
        return false;
         }
    }
}


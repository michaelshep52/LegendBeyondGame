using System;
using Legend.Domain.Entities;
using Legend.Domain.Interface;

namespace Legend.Domain.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        ILegendRepository<Account> AccountRepository { get; }
        ILegendRepository<Character> CharacterRepostiory { get; }

        int Save();
    }
}


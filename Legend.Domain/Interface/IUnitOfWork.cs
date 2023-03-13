using System;
using Legend.Domain.Entities;
using Legend.Domain.Interface;

namespace Legend.Domain.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        public ILegendRepository<Account> AccountRepository { get; }
        public ILegendRepository<Character> CharacterRepostiory { get; }
        public ILegendRepository<Inventory> InventoryRepostiory { get; }
        public ILegendRepository<Player> PlayerRepostiory { get; }

        int Save();
    }
}


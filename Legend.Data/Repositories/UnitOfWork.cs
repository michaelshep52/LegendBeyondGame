using System;
using Legend.Domain.Entities;
using Legend.Domain.Interface;

namespace Legend.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LegendContext _context;
        public ILegendRepository<Account> AccountRepository { get; }
        public ILegendRepository<Character> CharacterRepostiory { get; }
        public ILegendRepository<Inventory> InventoryRepostiory { get; }
        public ILegendRepository<Player> PlayerRepostiory { get; }



        public UnitOfWork(LegendContext Context,
                IAccountRepository accountRepository,
                ICharacterRepository characterRepository,
                IInventoryRepository inventoryRepostiory,
                IPlayerRepository playerRepostiory)
        {
            _context = Context;
            AccountRepository = accountRepository;
            CharacterRepostiory = characterRepository;
            InventoryRepostiory = inventoryRepostiory;
            PlayerRepostiory = playerRepostiory;
                
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}


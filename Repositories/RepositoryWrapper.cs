using System;
using Legend.API.Data;
using Legend.API.Interfaces;

namespace Legend.API.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private LegendContext _context;
        private IAccountRepository _account;
        private ICharacterRepository _character;

        public IAccountRepository Account
        {
            get
            {
                if (_account == null)
                {
                    _account = new AccountRepository(_context);
                }
                return _account;
            }
        }
        public ICharacterRepository Character
        {
            get
            {
                if (_character == null)
                {
                    _character = new CharacterRepository(_context);
                }
                return _character;
            }
        }
        public RepositoryWrapper(LegendContext Context)
        {
            _context = Context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}


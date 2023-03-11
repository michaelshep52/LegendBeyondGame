using Legend.API.Data;
using Legend.API.Data.Entities;
using Legend.API.Interfaces;


namespace Legend.API.Repositories
{
    public class AccountRepository : LegendRepository<Account>, IAccountRepository
    {
        public AccountRepository(LegendContext context) : base(context)
        {

        }
    }
}


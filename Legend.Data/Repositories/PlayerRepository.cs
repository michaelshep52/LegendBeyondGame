using System;
using Legend.Domain.Entities;
using Legend.Domain.Interface;

namespace Legend.Data.Repositories
{
    public class PlayerRepository : LegendRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(LegendContext context) : base(context)
        {
        }
    }
}


using System;
using Legend.Domain.Entities;
using Legend.Domain.Interface;

namespace Legend.Data.Repositories
{
    public class CharacterRepository : LegendRepository<Character>, ICharacterRepository
    {
        public CharacterRepository(LegendContext context) : base(context)
        {

        }
    }
}


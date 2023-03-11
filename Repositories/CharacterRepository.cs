using Legend.API.Data;
using Legend.API.Data.Entities;
using Legend.API.Interfaces;


namespace Legend.API.Repositories
{
    public class CharacterRepository : LegendRepository<Character>, ICharacterRepository
    {
        public CharacterRepository(LegendContext context) : base(context)
        {

        }
    }
}


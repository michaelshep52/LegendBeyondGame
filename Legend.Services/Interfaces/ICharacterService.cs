using System;
using Legend.Domain.Entities;

namespace Legend.Services.Interfaces
{
    public interface ICharacterService
    {
        Task<bool> CreateCharacter(Character character);

        Task<IEnumerable<Character>> GetAllCharacters();

        Task<Character> GetCharacterById(int characterId);

        Task<bool> UpdateCharacter(Character character);

        Task<bool> DeleteCharacter(int characterId);
    }
}


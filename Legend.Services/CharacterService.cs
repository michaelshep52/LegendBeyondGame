using System;
using Legend.Domain.Entities;
using Legend.Domain.Interface;
using Legend.Services.Interfaces;

namespace Legend.Services
{
    public class CharacterService : ICharacterService
    {
        public IUnitOfWork _unitOfWork;

        public CharacterService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateCharacter(Character character)
        {
            if (character != null)
            {
                await _unitOfWork.CharacterRepostiory.Add(character);

                var result = _unitOfWork.Save();

                if (result > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public async Task<bool> DeleteCharacter(int characterId)
        {
            if (characterId > 0)
            {
                var character = await _unitOfWork.CharacterRepostiory.GetById(characterId);
                if (character != null)
                {
                    _unitOfWork.CharacterRepostiory.Delete(character);
                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public async Task<IEnumerable<Character>> GetAllCharacters()
        {
            var characterList = await _unitOfWork.CharacterRepostiory.GetAll();
            return characterList;
        }

        public async Task<Character> GetCharacterById(int characterId)
        {
            if (characterId > 0)
            {
                var character = await _unitOfWork.CharacterRepostiory.GetById(characterId);
                if (character != null)
                {
                    return character;
                }
            }
            return null;
        }

        public async Task<bool> UpdateCharacter(Character character)
        {
            if (character != null)
            {
                var characterRepostiory = await _unitOfWork.CharacterRepostiory.GetById(character.CharacterId);
                if (characterRepostiory != null)
                {
                    characterRepostiory.Name = character.Name;
                    characterRepostiory.Health = character.Health;
                    characterRepostiory.Strength = character.Strength;
                    characterRepostiory.Speed = character.Speed;
                    characterRepostiory.Stamina = character.Stamina;


                    _unitOfWork.CharacterRepostiory.Update(characterRepostiory);

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


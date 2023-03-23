using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Legend.Domain.Entities;
using Legend.Services;
using Legend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Legend.API.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CharactersController : ControllerBase
    {
        public readonly ICharacterService _characterService;
        public CharactersController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> GetCharacterList()
        {
            var charactersList = await _characterService.GetAllCharacters();
            if (charactersList == null)
            {
                return NotFound();
            }
            return Ok(charactersList);
        }

        // GET api/values/5
        [HttpGet("{characterId}")]
        public async Task<IActionResult> GetCharacterById(int characterId)
        {
            var character = await _characterService.GetCharacterById(characterId);

            if (character != null)
            {
                return Ok(character);
            }
            else
            {
                return BadRequest();
            }
        }


        // POST api/values
        [HttpPost]
        public async Task<IActionResult> CreateAccount(Character character)
        {
            var isCharacterCreated = await _characterService.CreateCharacter(character);

            if (isCharacterCreated)
            {
                return Ok(isCharacterCreated);
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/values/5
        [HttpPut]
        public async Task<IActionResult> UpdateCharacter(Character character)
        {
            if (character != null)
            {
                var isCharacterCreated = await _characterService.UpdateCharacter(character);
                if (isCharacterCreated)
                {
                    return Ok(isCharacterCreated);
                }
                return BadRequest();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/values/5
        [HttpDelete("{characterId}")]
        public async Task<IActionResult> DeleteCharacter(int characterId)
        {
            var isCharacterCreated = await _characterService.DeleteCharacter(characterId);

            if (isCharacterCreated)
            {
                return Ok(isCharacterCreated);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}


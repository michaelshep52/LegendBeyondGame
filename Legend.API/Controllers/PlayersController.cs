using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Legend.Domain.Entities;
using Legend.Services;
using Legend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Legend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        public readonly IPlayerService _playerService;
        public PlayersController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> GetPlayersList()
        {
            var playersList = await _playerService.GetAllPlayers();
            if (playersList == null)
            {
                return NotFound();
            }
            return Ok(playersList);
        }

        // GET api/values/5
        [HttpGet("{playerId}")]
        public async Task<IActionResult> GetPlayerById(int playerId)
        {
            var player = await _playerService.GetPlayerById(playerId);

            if (player != null)
            {
                return Ok(player);
            }
            else
            {
                return BadRequest();
            }
        }


        // POST api/values
        [HttpPost]
        public async Task<IActionResult> CreatePlayer(Player player)
        {
            var isPlaerCreated = await _playerService.CreatePlayer(player);

            if (isPlaerCreated)
            {
                return Ok(isPlaerCreated);
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/values/5
        [HttpPut]
        public async Task<IActionResult> UpdatePlayer(Player player)
        {
            if (player != null)
            {
                var isPlaerCreated = await _playerService.UpdatePlayer(player);
                if (isPlaerCreated)
                {
                    return Ok(isPlaerCreated);
                }
                return BadRequest();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/values/5
        [HttpDelete("{playerId}")]
        public async Task<IActionResult> DeletePlayer(int playerId)
        {
            var isPlaerCreated = await _playerService.DeletePlayer(playerId);

            if (isPlaerCreated)
            {
                return Ok(isPlaerCreated);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Legend.Domain.Entities;
using Legend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Legend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        public readonly IInventoryService _inventoryService;
        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> GetInventoryList()
        {
            var inventoryList = await _inventoryService.GetAllInventory();
            if (inventoryList == null)
            {
                return NotFound();
            }
            return Ok(inventoryList);
        }

        // GET api/values/5
        [HttpGet("{inventoryId}")]
        public async Task<IActionResult> GetInventoryById(int inventoryId)
        {
            var inventory = await _inventoryService.GetInventoryById(inventoryId);

            if (inventory != null)
            {
                return Ok(inventory);
            }
            else
            {
                return BadRequest();
            }
        }


        // POST api/values
        [HttpPost]
        public async Task<IActionResult> CreateInventory(Inventory inventory)
        {
            var isInventoryCreated = await _inventoryService.CreateInventory(inventory);

            if (isInventoryCreated)
            {
                return Ok(isInventoryCreated);
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/values/5
        [HttpPut]
        public async Task<IActionResult> UpdateInventory(Inventory inventory)
        {
            if (inventory != null)
            {
                var isInventoryCreated = await _inventoryService.UpdateInventory(inventory);
                if (isInventoryCreated)
                {
                    return Ok(isInventoryCreated);
                }
                return BadRequest();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/values/5
        [HttpDelete("{inventoryId}")]
        public async Task<IActionResult> DeleteInventory(int inventoryId)
        {
            var isInventoryCreated = await _inventoryService.DeleteInventory(inventoryId);

            if (isInventoryCreated)
            {
                return Ok(isInventoryCreated);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}




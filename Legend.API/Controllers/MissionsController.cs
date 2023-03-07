using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Legend.Data;
using Legend.Domain.Entities;

namespace Legend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MissionsController : ControllerBase
    {
        private readonly LegendContext _context;

        public MissionsController(LegendContext context)
        {
            _context = context;
        }

        Mission[] missions = new Mission[]
        {
            new Mission{MissionId=0, Name="Getting Started", Text="Kill 1 Enemy without Dying!", IsActive=true},
            new Mission{MissionId=1, Name="Bot", Text="Kill 10 Enemy without Dying!", IsActive=true},
            new Mission{MissionId=2, Name="Starting somewhere", Text="Kill 20 Enemy without Dying!", IsActive=true},
            new Mission{MissionId=3, Name="Building a RESUME", Text="Kill 40 Enemy without Dying!", IsActive=true},
            new Mission{MissionId=4, Name="Your a savage", Text="Kill 50 Enemy without Dying!", IsActive=true},
            new Mission{MissionId=5, Name="King Slayer", Text="Kill 75 Enemy without Dying!", IsActive=true},
            new Mission{MissionId=6, Name="Duty Calls", Text="Kill 85 Enemy without Dying!", IsActive=true},
            new Mission{MissionId=7, Name="Best to ever be", Text="Kill 100 Enemy without Dying!", IsActive=true}
        };


        // GET: api/Missions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mission>>> GetMissions()
        {
          if (_context.Missions == null)
          {
              return NotFound();
          }
            return await _context.Missions.ToListAsync();
        }

        // GET: api/Missions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mission>> GetMission(int id)
        {
          if (_context.Missions == null)
          {
              return NotFound();
          }
            var mission = await _context.Missions.FindAsync(id);

            if (mission == null)
            {
                return NotFound();
            }

            return mission;
        }

        // PUT: api/Missions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMission(int id, Mission mission)
        {
            if (id != mission.MissionId)
            {
                return BadRequest();
            }

            _context.Entry(mission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MissionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Missions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Mission>> PostMission(Mission mission)
        {
          if (_context.Missions == null)
          {
              return Problem("Entity set 'LegendContext.Missions'  is null.");
          }
            _context.Missions.Add(mission);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMission", new { id = mission.MissionId }, mission);
        }

        // DELETE: api/Missions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMission(int id)
        {
            if (_context.Missions == null)
            {
                return NotFound();
            }
            var mission = await _context.Missions.FindAsync(id);
            if (mission == null)
            {
                return NotFound();
            }

            _context.Missions.Remove(mission);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MissionExists(int id)
        {
            return (_context.Missions?.Any(e => e.MissionId == id)).GetValueOrDefault();
        }
    }
}

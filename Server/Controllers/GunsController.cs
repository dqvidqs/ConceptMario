using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GunsController : ControllerBase
    {
        private readonly GameContext _context;

        public GunsController(GameContext context)
        {
            _context = context;
        }

        // GET: api/Guns
        [HttpGet]
        public IEnumerable<Gun> GetGuns()
        {
            return _context.Guns;
        }

        // GET: api/Guns/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGun([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var gun = await _context.Guns.FindAsync(id);

            if (gun == null)
            {
                return NotFound();
            }

            return Ok(gun);
        }

        // PUT: api/Guns/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGun([FromRoute] int id, [FromBody] Gun gun)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != gun.id)
            {
                return BadRequest();
            }

            _context.Entry(gun).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GunExists(id))
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

        // POST: api/Guns
        [HttpPost]
        public async Task<IActionResult> PostGun([FromBody] Gun gun)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

			gun.id = _context.Guns.Count()+1;

			_context.Guns.Add(gun);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Guns/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGun([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var gun = await _context.Guns.FindAsync(id);
            if (gun == null)
            {
                return NotFound();
            }

            _context.Guns.Remove(gun);
            await _context.SaveChangesAsync();

            return Ok(gun);
        }

        private bool GunExists(int id)
        {
            return _context.Guns.Any(e => e.id == id);
        }
    }
}
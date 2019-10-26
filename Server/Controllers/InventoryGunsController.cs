using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Objects.Models;
using Server.Database;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryGunsController : ControllerBase
    {
        private readonly GameContext _context;

        public InventoryGunsController(GameContext context)
        {
            _context = context;
        }

        // GET: api/InventoryGuns
        [HttpGet]
        public IEnumerable<InventoryGun> GetInventoryGuns()
        {
            return _context.InventoryGuns.Include(g=>g.Gun);
        }

        // GET: api/InventoryGuns/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInventoryGun([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var inventoryGun = await _context.InventoryGuns.FindAsync(id);

            if (inventoryGun == null)
            {
                return NotFound();
            }

            return Ok(inventoryGun);
        }

        // PUT: api/InventoryGuns/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInventoryGun([FromRoute] int id, [FromBody] InventoryGun inventoryGun)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != inventoryGun.id)
            {
                return BadRequest();
            }

            _context.Entry(inventoryGun).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InventoryGunExists(id))
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

        // POST: api/InventoryGuns
        [HttpPost]
        public async Task<IActionResult> PostInventoryGun([FromBody] InventoryGun inventoryGun)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.InventoryGuns.Add(inventoryGun);
            await _context.SaveChangesAsync();

			return NoContent();
		}

        // DELETE: api/InventoryGuns/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInventoryGun([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var inventoryGun = await _context.InventoryGuns.FindAsync(id);
            if (inventoryGun == null)
            {
                return NotFound();
            }

            _context.InventoryGuns.Remove(inventoryGun);
            await _context.SaveChangesAsync();

            return Ok(inventoryGun);
        }

        private bool InventoryGunExists(int id)
        {
            return _context.InventoryGuns.Any(e => e.id == id);
        }
    }
}
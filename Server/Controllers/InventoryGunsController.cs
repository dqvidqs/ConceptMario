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
        public IEnumerable<Inventory_gun> GetInventory_guns()
        {
            return _context.Inventory_Guns;
        }

        // GET: api/InventoryGuns/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInventory_gun([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var inventory_gun = await _context.Inventory_Guns.FindAsync(id);

            if (inventory_gun == null)
            {
                return NotFound();
            }

            return Ok(inventory_gun);
        }

        // PUT: api/InventoryGuns/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInventory_gun([FromRoute] int id, [FromBody] Inventory_gun inventory_gun)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != inventory_gun.id)
            {
                return BadRequest();
            }

            _context.Entry(inventory_gun).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Inventory_gunExists(id))
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
        public async Task<IActionResult> PostInventory_gun([FromBody] Inventory_gun inventory_gun)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Inventory_Guns.Add(inventory_gun);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInventory_gun", new { id = inventory_gun.id }, inventory_gun);
        }

        // DELETE: api/InventoryGuns/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInventory_gun([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var inventory_gun = await _context.Inventory_Guns.FindAsync(id);
            if (inventory_gun == null)
            {
                return NotFound();
            }

            _context.Inventory_Guns.Remove(inventory_gun);
            await _context.SaveChangesAsync();

            return Ok(inventory_gun);
        }

        private bool Inventory_gunExists(int id)
        {
            return _context.Inventory_Guns.Any(e => e.id == id);
        }
    }
}
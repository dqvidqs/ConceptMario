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
    public class DiamondsController : ControllerBase
    {
        private readonly GameContext _context;

        public DiamondsController(GameContext context)
        {
            _context = context;
        }

        // GET: api/Diamonds
        [HttpGet]
        public IEnumerable<Diamond> GetDiamond()
        {
            return _context.Diamond;
        }

        // GET: api/Diamonds/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDiamond([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var diamond = await _context.Diamond.FindAsync(id);

            if (diamond == null)
            {
                return NotFound();
            }

            return Ok(diamond);
        }

        // PUT: api/Diamonds/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDiamond([FromRoute] int id, [FromBody] Diamond diamond)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != diamond.id)
            {
                return BadRequest();
            }

            _context.Entry(diamond).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DiamondExists(id))
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

        // POST: api/Diamonds
        [HttpPost]
        public async Task<IActionResult> PostDiamond([FromBody] Diamond diamond)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Diamond.Add(diamond);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDiamond", new { id = diamond.id }, diamond);
        }

        // DELETE: api/Diamonds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiamond([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var diamond = await _context.Diamond.FindAsync(id);
            if (diamond == null)
            {
                return NotFound();
            }

            _context.Diamond.Remove(diamond);
            await _context.SaveChangesAsync();

            return Ok(diamond);
        }

        private bool DiamondExists(int id)
        {
            return _context.Diamond.Any(e => e.id == id);
        }
    }
}
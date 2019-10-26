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
    public class UsersController : ControllerBase
    {
        private readonly GameContext _context;

        public UsersController(GameContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
			return _context.Users;
        }

        // GET: api/Users/Logged
        [HttpGet("logged")]
        public int GetLoggedUsers()
        {
	        return _context.Users.Where(x=>x.status==true).Count();
        }

		// GET: api/Users/5
		[HttpPut]
        public async Task<IActionResult> GetUser([FromBody] User usr)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

			var user = await _context.Users.FirstAsync(x => x.username == usr.username && x.password == usr.password);

            if (user == null)
            {
                return NotFound();
            }

            user.status = true;
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();

			return Ok(user);
        }

        // GET: api/Users/logout/5
        [HttpGet("logout/{id}")]
        public async Task<IActionResult> Logout([FromRoute] int id)
        {
	        if (!ModelState.IsValid)
	        {
		        return BadRequest(ModelState);
	        }

	        var user = await _context.Users.FindAsync(id);

	        if (user == null)
	        {
		        return NotFound();
	        }

	        user.status = false;
	        _context.Entry(user).State = EntityState.Modified;
	        await _context.SaveChangesAsync();

	        return NoContent();
        }

		// PUT: api/Users/5
		[HttpPut("{id}")]
        public async Task<IActionResult> PutUser([FromRoute] int id, [FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user.id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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

        // POST: api/Users
        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
			int id = _context.Users.Count() + 1;
			user.id = id;
			_context.Users.Add(user);
            await _context.SaveChangesAsync();

			Inventory inventory = new Inventory();
			inventory.id = id;
			_context.Inventories.Add(inventory);
			await _context.SaveChangesAsync();

			Character character = new Character();
			character.id = id;
			character.fk_user = id;
			character.fk_inventory= id;
			character.x = 25;
			character.y = 25;
			_context.Characters.Add(character);
			await _context.SaveChangesAsync();

			return Ok(user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return Ok(user);
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.id == id);
        }
    }
}
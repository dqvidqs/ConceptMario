using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Objects.Models;
using Server.Database;
using Server.Facades;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UsersFacade _facade;

        public UsersController(GameContext context)
        {
            _facade = new UsersFacade(context);
        }

        // GET: api/Users
        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _facade.GetUsers();                
        }

        // GET: api/Users/Logged
        [HttpGet("logged")]
        public async Task<int> GetLoggedUsersCount()
        {
            return await _facade.GetLoggedInCount();
        }

		// GET: api/Users/5
		[HttpPut]
        public async Task<IActionResult> GetUser([FromBody] User usr)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var user = await _facade.GetUser(usr);
                return Ok(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        // GET: api/Users/logout/5
        [HttpGet("logout/{id}")]
        public async Task<IActionResult> Logout([FromRoute] int id)
        {
	        if (!ModelState.IsValid)
	        {
		        return BadRequest(ModelState);
	        }

            try
            {
                await _facade.Logout(id);
                return NoContent();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        // POST: api/Users
        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var returnUser = await _facade.CreateUser(user);

            return Ok(returnUser);
        }

    }
}
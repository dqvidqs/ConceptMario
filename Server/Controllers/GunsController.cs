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
    public class GunsController : ControllerBase
    {
        private readonly GameContext _context;
        private readonly GunFacade _facade;

        // todo: remove context
        public GunsController(GameContext context)
        {
            _facade = new GunFacade(context);
            _context = context;
        }

       // GET: api/Guns
       //[HttpGet()]
        public async Task<IEnumerable<Gun>> Get()
        {
            var guns = await _facade.GetShopGuns();
            return guns;
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

    }
}
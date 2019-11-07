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
    public class AbilitiesController : ControllerBase
    {
        private readonly AbilitiesFacade _facade;
        public AbilitiesController(GameContext context)
        {
            _facade = new AbilitiesFacade(context);
        }

        // GET: api/Abilities
        [HttpGet]
        public async Task<IEnumerable<Ability>> GetAbilitys()
        {
            return await _facade.GetAllAvailableAbilities();
        }

        // GET: api/Abilities/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAbility([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ability = await _facade.GetAbility(id);

            if (ability == null)
            {
                return NotFound();
            }

            return Ok(ability);
        }

    }
}
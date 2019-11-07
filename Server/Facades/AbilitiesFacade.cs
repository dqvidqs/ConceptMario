
using Objects.Models;
using Server.Database;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Server.Facades
{
    class AbilitiesFacade : BaseFacade
    {
        public AbilitiesFacade(GameContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Ability>> GetAllAvailableAbilities()
        {
            return await Task.FromResult(_context.Abilities);
        }

        public async Task<Ability> GetAbility(int id)
        {
            return await _context.Abilities.FindAsync(id);
        }

        public async Task<Ability> InsertAbility(Ability ability)
        {
            ability.id = (await GetAllAvailableAbilities()).Count();
            _context.Abilities.Add(ability);
            await _context.SaveChangesAsync();

            return ability;
        }

        public async Task DeleteAbility(int id)
        {
            var ability = await _context.Abilities.FindAsync(id);

            if(ability == null)
            {
                throw new Exception("Ability not found");
            }

            _context.Abilities.Remove(ability);
            await _context.SaveChangesAsync();
        }


    }
}
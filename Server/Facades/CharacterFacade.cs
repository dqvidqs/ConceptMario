using Objects.Models;
using Server.Database;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Server.Facades
{
    class CharacterFacade : BaseFacade
    {
        public CharacterFacade(GameContext context) : base(context)
        {
        }

        public async Task EquipGun(Gun gun)
        {
            // todo: equip gun to character

            await Task.CompletedTask;
        }

        public async Task AddAbility(Ability ability)
        {
            // todo: add ability to character

            await Task.CompletedTask;
        }

    }
}
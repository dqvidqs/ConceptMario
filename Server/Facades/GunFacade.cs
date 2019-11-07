using Objects.Models;
using Server.Database;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Server.Shop;

namespace Server.Facades
{
    class GunFacade : BaseFacade
    {
        public GunFacade(GameContext context) : base(context)
        {
        }

        //public async Task<List<Gun>> GetShopGuns()
        //{
        //    return await Task.FromResult(CurrentShopItems.GetShop().Guns);
        //}

    }
}
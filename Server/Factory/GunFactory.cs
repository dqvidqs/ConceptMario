using Objects.Characters.PlayerAssets.Guns;
using Objects.Characters.PlayerAssets;
using System.Collections.Generic;

namespace Server.Factory
{
    public class GunFactory
    {               
       public static Gun ReturnItem()
        {
            return new Pistol1();
        }
    }
}
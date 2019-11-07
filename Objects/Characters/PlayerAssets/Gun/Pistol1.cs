using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptMario.Assets.Characters.PlayerAssets
{
    public class Pistol1 : Gun
    {
        public Pistol1() : base(FireRate: 60, Ammo: 7, "Useless pistol")
        {
        }
    }
}

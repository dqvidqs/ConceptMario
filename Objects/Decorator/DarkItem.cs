using ConceptMario.Assets.Characters.PlayerAssets;

namespace Objects.Decorator
{
    public class DarkItem : Gun
    {
        public DarkItem(Gun gun) : base((int) (gun.FireRate * 1.5), gun.Ammo, "Dark " + gun.Name)
        {

        }
    }
}

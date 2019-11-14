using Objects.Characters.PlayerAssets;

namespace Objects.Decorator
{
    public class DarkItem : GunDecorator
    {
        /*public DarkItem(Gun gun) : base((int) (gun.FireRate * 1.5), gun.Ammo, "Dark " + gun.Name)
        {

        }*/
        public DarkItem(IGun Gun) : base(Gun)
        {
            if (Gun is Gun)
            {
                Upgrade(0.5, 2, "Dark ");
            }
            else
            {
                var gun = this.Gun as EndlessItem;
                gun.Upgrade(0.5, 2, "Dark ");
            }
        }
    }
}

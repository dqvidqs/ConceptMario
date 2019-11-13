using Objects.Characters.PlayerAssets;

namespace Objects.Decorator
{
    public class EndlessItem : Gun
    {
        public EndlessItem(Gun gun) : base(gun.FireRate, (int)(gun.Ammo * 1.5), "Endless " + gun.Name)
        {

        }
    }
}

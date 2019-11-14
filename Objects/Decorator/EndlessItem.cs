using Objects.Characters.PlayerAssets;

namespace Objects.Decorator
{
    public class EndlessItem : GunDecorator
    {
        public EndlessItem(IGun Gun) : base(Gun)
        {
            if (Gun is Gun)
            {
                Upgrade(0.5, 2, "Endless ");
            }
            else
            {
                var gun = this.Gun as DarkItem;
                gun.Upgrade(0.5, 2, "Endless ");
            }
        }
    }
}

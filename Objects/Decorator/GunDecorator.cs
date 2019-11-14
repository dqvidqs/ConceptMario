using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objects.Characters.PlayerAssets;
using Objects.Enums;

namespace Objects.Decorator
{
    public abstract class GunDecorator : IGun
    {
        protected IGun Gun;
        public GunDecorator(IGun Gun)
        {
            this.Gun = Gun;
        }
        public void Relaod()
        {
            Gun.Relaod();
        }

        public BulletData Shoot(int x, int y, Directions direction)
        {
            return Gun.Shoot(x, y, direction);
        }

        public void Update()
        {
            Gun.Update();
        }
        public void Upgrade(double FireRateCoefficient, double AmmoCoefficient, string Name)
        {
            var Gun = this.Gun as Gun;
            Gun.FireRate = (int)(Gun.FireRate * FireRateCoefficient);
            Gun.Ammo = (int)(Gun.Ammo * AmmoCoefficient);
            Gun.Name = Name + Gun.Name;
            Gun.Reset();
            this.Gun = Gun;
        }
    }
}

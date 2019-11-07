using Objects.Enums;
using System;

namespace ConceptMario.Assets.Characters.PlayerAssets
{

    [Serializable]
    public abstract class Gun
    {


        public int FireRate;
        protected int CurrectRate;
        public int Ammo;
        protected int CurrectAmmo;
        public string Name;

        public Gun(int FireRate, int Ammo, string name = "Gun")
        {
            CurrectAmmo = Ammo;
            CurrectRate = FireRate;
            this.Ammo = Ammo;
            this.FireRate = FireRate;
            Name = name;
        }
        public void Update()
        {
            if (CurrectRate != FireRate)
            {
                CurrectRate++;
            }
        }

        public BulletData Shoot(int x, int y, Directions direction)
        {
            if (CurrectAmmo > 0 && CurrectRate == FireRate)
            {
                CurrectRate = 0;
                CurrectAmmo--;
                return new BulletData { X = x, Y = y, Direction = (int) direction, BulletSpeed = 20 };
            }
            else
                return null;
        }

        public void Relaod()
        {
            CurrectAmmo = Ammo;
        }
    }
}

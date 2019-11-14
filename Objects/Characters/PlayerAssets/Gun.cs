using Objects.Enums;
using System;


namespace Objects.Characters.PlayerAssets
{
    [Serializable]
    public class Gun : IGun
    {
        public int FireRate { get; set; }
        protected int CurrectRate;
        public int Ammo { get; set; }
        protected int CurrectAmmo;
        public string Name { get; set; }

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
                return new BulletData { X = x, Y = y, Direction = (int) direction, BulletSpeed = 25 };
            }
            else
                return null;
        }

        public void Relaod()
        {
            CurrectAmmo = Ammo;
        }
        public void Reset()
        {
            CurrectRate = FireRate;
            CurrectAmmo = Ammo;
        }
    }
}

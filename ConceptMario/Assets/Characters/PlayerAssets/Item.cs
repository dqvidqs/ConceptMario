using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Controls;

namespace ConceptMario.Assets.Characters.PlayerAssets
{
    abstract class Item
    {
        protected int FireRate;
        protected int CurrectRate;
        protected int Ammo;
        protected int CurrectAmmo;
        ShapeFactory.Factory factory = new ShapeFactory.Factory();
        public Item(int FireRate, int Ammo)
        {
            CurrectAmmo = Ammo;
            CurrectRate = FireRate;
            this.Ammo = Ammo;
            this.FireRate = FireRate;           
        }
        public void Update()
        {
            if (CurrectRate != FireRate)
            {
                CurrectRate++;
            }
        }
        public Bullet Shoot(int X, int Y,int Direction)
        {
            if (CurrectAmmo > 0 && CurrectRate == FireRate)
            {
                CurrectRate = 0;
                CurrectAmmo--;
                return new Bullet { X = X, Y = Y, bullet = factory.GetShape("bullet").Get(), Direction = Direction, BulletSpeed= MetaData.Size};
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

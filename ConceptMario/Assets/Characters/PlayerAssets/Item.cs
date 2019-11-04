﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Controls;
using ConceptMario.Assets.ShapeFactory;

namespace ConceptMario.Assets.Characters.PlayerAssets
{
    public abstract class Item
    {
        protected int FireRate;
        protected int CurrectRate;
        protected int Ammo;
        protected int CurrectAmmo;
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
                return new Bullet { X = X, Y = Y, bullet = Factory.GetShape("bullet").Get(), Direction = Direction, BulletSpeed= MetaData.Size};
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

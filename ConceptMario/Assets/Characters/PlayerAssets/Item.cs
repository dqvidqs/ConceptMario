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
        protected int BulletSpeed = MetaData.Size;
        protected int FireRate;
        protected int CurrectRate;
        protected int Ammo;
        protected int CurrectAmmo;
        ShapeFactory.ShapeFactory factory = new ShapeFactory.ShapeFactory();
        //protected Polygon Bullet;
        protected List<Bullet> Bullets = new List<Bullet>();
        public Item(int FireRate, int Ammo)
        {
            CurrectAmmo = Ammo;
            CurrectRate = FireRate;
            this.Ammo = Ammo;
            this.FireRate = FireRate;           
        }
        public void Update(Canvas canvas)
        {
            if (CurrectRate != FireRate)
            {
                CurrectRate++;
            }
            for (int i = 0; i < Bullets.Count; i++)
            {
                if (!canvas.Children.Contains(Bullets[i].bullet))
                    canvas.Children.Add(Bullets[i].bullet);
                Canvas.SetBottom(Bullets[i].bullet, Bullets[i].Y);
                Canvas.SetLeft(Bullets[i].bullet, Bullets[i].X);
                Bullets[i].X += BulletSpeed* Bullets[i].Direction;
                if (Bullets[i].X > MetaData.WidthPx || Bullets[i].X < 0)
                {
                    canvas.Children.Remove(Bullets[i].bullet);
                    Bullets.RemoveAt(i);
                }
            }
        }
        public void Shoot(int X, int Y,int Direction)
        {
            if (CurrectAmmo > 0 && CurrectRate == FireRate)
            {
                CurrectRate = 0;
                Bullets.Add(new Bullet { X = X, Y = Y, bullet = factory.GetShape("bullet").Get(),Direction=Direction });
                CurrectAmmo--;
            }
        }
        public void Relaod()
        {
            CurrectAmmo = Ammo;
        }
    }
}

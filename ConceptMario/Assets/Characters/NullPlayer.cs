using System.Windows.Shapes;
using System.Windows.Controls;
using System.Collections.Generic;
using ConceptMario.Assets.ShapeFactory;
using Objects.Characters.PlayerAssets;
using Objects.Characters.PlayerAssets.Guns;
using System.Linq;
using Objects.Enums;
using Objects.Decorator;
using System;

namespace ConceptMario.Assets.Characters
{
    abstract class NullPlayer :IPlayer
    {
        //instance, kuri galime naudoti lyginant
        public static readonly IPlayer Null=new NullEmptyPlayer();
        //null case
        private class NullEmptyPlayer : IPlayer
        {
            public Polygon Object;
            public int Size = MetaData.Size;
            public int X;
            public int Y;
            public int[] DinamicJump = { 30, 25, 20, 15, 10 };
            public int DinamicIterartion = 0;
            public int MoveSpeed = 5;
            public int Direction = 1;
            public Inventory Inv;

            public int HitPoints { set; get; }
            public int Coin { set; get; }
            public bool CanJump { set; get; }
            public bool IsJump { set; get; }
            public bool CanLeft { set; get; }
            public bool Left { set; get; }
            public bool CanRight { set; get; }
            public bool Right { set; get; }
            public bool IsShooting { get; set; }
            private int gunDamage;
            public int GunDamage { get { return gunDamage; } }
            public bool isDead = false;

            public NullEmptyPlayer(int X, int Y)
            {
                //this.HitPoints = 100;
                //Object = Factory.GetShape("player").Get();
                //Inv = new Inventory();
                //this.X = X;
                //this.Y = Y;
                //CanRight = true;
                //CanLeft = true;
                //Inv.AddItem(new DarkItem(new EndlessItem(new Pistol())));
            }

            public NullEmptyPlayer()
            {
            }

            public void Update(int X, int Y)
            {
                //this.X = X;
                //this.Y = Y;
            }
            public void Update()
            {
                //if (!isDead)
                //{
                //    Canvas.SetBottom(Object, Y);
                //    Canvas.SetLeft(Object, X);
                //    Inv.GetItem().Update();
                //    Move();
                //}
            }

            public List<BulletData> GetBullet()
            {
                return Inv.GetBulletsData();
            }

            public void RemoveBullet(int i)
            {
                //Inv.RemoveBullet(i);
            }

            public Polygon Get()
            {
                return Object;
            }
            public void Set()
            {
                //Object = Factory.GetShape("player-dead").Get();
            }
            public int GetX() { return X; }
            public int GetCenterX() { return X + Size / 2; }
            public int GetY() { return Y; }
            public int GetCenterY() { return Y + Size / 2; }
            public void Reload()
            {
                //Inv.GetItem().Relaod();
            }
            public void Move()
            {
                //Gravity();
                //if (IsShooting) { Shooting(); }
                //if (Left) { MoveLeft(); }
                //if (Right) { MoveRight(); }
                //if (IsJump) { MoveUp(); }
            }
            public void Shooting()
            {
                //gunDamage = Inv.Shoot(X, Y, (Directions)Direction);
            }

            public void Gravity()
            {
                //if (!CanJump)
                //{
                //    Y -= MoveSpeed;
                //}
            }
            public void MoveLeft()
            {
                //if (CanLeft)
                //{
                //    X -= MoveSpeed;
                //    Direction = -1;
                //}
            }
            public void MoveRight()
            {
                //if (CanRight)
                //{
                //    X += MoveSpeed;
                //    Direction = 1;
                //}
            }
            public void MoveUp()
            {
                //try
                //{
                //    if (CanJump)
                //    {
                //        CanJump = false;
                //        Y += DinamicJump[DinamicIterartion++];
                //    }
                //    else if (DinamicIterartion != DinamicJump.Length - 1 && DinamicIterartion != 0)
                //    {
                //        CanJump = false;
                //        Y += DinamicJump[DinamicIterartion++];
                //    }
                //    else
                //    {
                //        IsJump = false;
                //        DinamicIterartion = 0;
                //    }
                //}
                //catch
                //{
                //    DinamicIterartion = 0;
                //    CanJump = false;
                //}
            }
        }

        public abstract void Update(int X, int Y);
        public abstract void Update();
        public abstract List<BulletData> GetBullet();
        public abstract void RemoveBullet(int i);
        public abstract Polygon Get();
        public abstract void Set();
        public abstract int GetX();
        public abstract int GetCenterX();
        public abstract int GetY();
        public abstract int GetCenterY();
        public abstract void Reload();
        public abstract void Move();
        public abstract void Shooting();

        public abstract void Gravity();
        public abstract void MoveLeft();
        public abstract void MoveRight();
        public abstract void MoveUp();

    }
}

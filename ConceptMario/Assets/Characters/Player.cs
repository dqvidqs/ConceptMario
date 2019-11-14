using System.Windows.Shapes;
using System.Windows.Controls;
using System.Collections.Generic;
using ConceptMario.Assets.ShapeFactory;
using Objects.Characters.PlayerAssets;
using Objects.Characters.PlayerAssets.Guns;
using System.Linq;
using Objects.Enums;
using Objects.Decorator;

namespace ConceptMario.Assets.Characters
{
    public class Player
    {
        private Polygon Object;
        private int Size = MetaData.Size;
        private int X;
        private int Y;
        private int[] DinamicJump = { 30, 25, 20, 15, 10 };
        private int DinamicIterartion = 0;
        private int MoveSpeed = 5;
        private int Direction = 1;
        private Inventory Inv;

        public int HitPoints { set; get; }
        public bool CanJump { set; get; }
        public bool IsJump { set; get; }
        public bool CanLeft { set; get; }
        public bool Left { set; get; }
        public bool CanRight { set; get; }
        public bool Right { set; get; }
        public bool IsShooting { get; set; }

        public Player(int X, int Y)
        {
            this.HitPoints = 100;
            Object = Factory.GetShape("player").Get();
            Inv = new Inventory();
            this.X = X;
            this.Y = Y;
            CanRight = true;
            CanLeft = true;
            //Inv.AddItem(new Pistol());
            //IGun Gun = new Gun(20, 7, "Pistol");
            //Gun = new EndlessItem(Gun);
            Inv.AddItem(new DarkItem(new EndlessItem(new Pistol())));
        }
		public void Update(int X, int Y)
		{
			this.X = X;
			this.Y = Y;
		}
        public void Update()
        {
            Canvas.SetBottom(Object,Y);
            Canvas.SetLeft(Object, X);
            Inv.GetItem().Update();
            Move();
        }

        public List<BulletData> GetBullet()
        {
            return Inv.GetBulletsData();
        }

        public void RemoveBullet(int i)
        {
            Inv.RemoveBullet(i);
        }

        public Polygon Get()
        {
            return Object;
        }
        public int GetX() { return X; }
        public int GetCenterX() { return X + Size / 2; }
        public int GetY() { return Y; }
        public int GetCenterY() { return Y + Size / 2; }
        public void Reload()
        {
            Inv.GetItem().Relaod();
        }
        private void Move()
        {
            Gravity();
            if(IsShooting) { Shooting(); }
            if (Left) { MoveLeft(); }
            if (Right) { MoveRight(); }
            if (IsJump) { MoveUp(); }
        }
        private void Shooting()
        {
            Inv.Shoot(X, Y, (Directions) Direction);
        }

        private void Gravity()
        {
            if (!CanJump)
            {
                Y -= MoveSpeed;
            }
        }
        private void MoveLeft()
        {
            if (CanLeft)
            {
                X -= MoveSpeed;
                Direction = -1;
            }
        }
        private void MoveRight()
        {
            if (CanRight)
            {
                X += MoveSpeed;
                Direction = 1;
            }
        }
        private void MoveUp()
        {
            try//Chujovai veikia, reiks tvarkyt
            {
                if (CanJump)
                {
                    CanJump = false;
                    Y += DinamicJump[DinamicIterartion++];
                }
                else if (DinamicIterartion != DinamicJump.Length - 1 && DinamicIterartion != 0)
                {
                    CanJump = false;
                    Y += DinamicJump[DinamicIterartion++];
                }
                else
                {
                    IsJump = false;
                    DinamicIterartion = 0;
                }
            }
            catch
            {
                DinamicIterartion = 0;
                CanJump = false;
                //Todel expectionas yra XDDDDD
            }
        }
    }
}
using System.Windows.Shapes;

using ConceptMario.Assets.Characters.PlayerAssets;

namespace ConceptMario.Assets.Characters
{
    public class Player
    {
        private Polygon Object = null;
        private int Size = MetaData.Size;
        private int X;
        private int Y;
        private int[] DinamicJump = { 30, 25, 20, 15, 10 };
        private int DinamicIterartion = 0;
        private int MoveSpeed = 5;
        private bool DirectionRight = false;
        private bool DirectionLeft = true;
        private Inventory Inv = new Inventory();

        public bool CanJump { set; get; }
        public bool IsJump { set; get; }
        public bool CanLeft { set; get; }
        public bool Left { set; get; }
        public bool CanRight { set; get; }
        public bool Right { set; get; }
        public bool IsShooting { get; set; }

        public Player(int X, int Y)
        {
            ShapeFactory.ShapeFactory Factory = new ShapeFactory.ShapeFactory();
            Object = Factory.GetShape("player").Get();
            this.X = X;
            this.Y = Y;
            CanRight = true;
            CanLeft = true;
            Inv.AddItem(new Pistol(20, 7));
        }
		public void Update(int X, int Y)
		{
			this.X = X;
			this.Y = Y;
		}
        public Polygon Get()
        {
            return Object;
        }
        public int GetX() { return X; }
        public int GetCenterX() { return X + Size / 2; }
        public int GetY() { return Y; }
        public int GetCenterY() { return Y + Size / 2; }
        public void Inventory()
        {
        }
        public void Move()
        {
            Gravity();
            if(IsShooting) { Shooting(); }
            if (Left) { MoveLeft(); }
            if (Right) { MoveRight(); }
            if (IsJump) { MoveUp(); }
        }
        private void Shooting()
        {
            Inv.Behave(X, Y);
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
                DirectionRight = false;
                DirectionLeft = true;
            }
        }
        private void MoveRight()
        {
            if (CanRight)
            {
                X += MoveSpeed;
                DirectionRight = false;
                DirectionLeft = true;
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
using System.Windows.Shapes;

namespace ConceptMario.Assets
{
    class Player
    {
        private Polygon Object = null;
        private int Size = MetaData.Size;
        private int X;
        private int Y;
        private int[] DinamicJump = { 30, 25, 20, 15, 10 };
        private int DinamicIterartion = 0;
        private int MoveSpeed = 5;

        public bool CanJump { set; get; }
        public bool IsJump { set; get; }
        public bool CanLeft { set; get; }
        public bool Left { set; get; }
        public bool CanRight { set; get; }
        public bool Right { set; get; }

        public Player(int X, int Y)
        {
            /*Object = new Ellipse();
            Object.Stroke = System.Windows.Media.Brushes.Black;
            Object.Fill = System.Windows.Media.Brushes.Red;
            Object.Height = Size;
            Object.Width = Size;*/
            ShapeFactory.ShapeFactory Factory = new ShapeFactory.ShapeFactory();
            Object = Factory.GetShape("player").Get();
            this.X = X;
            this.Y = Y;
            CanRight = true;
            CanLeft = true;
        }
		public void update(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}
        public Polygon Get()
        {
            return Object;
        }
        public int GetX() { return X; }
        public int GetCenterX() { return X + Size / 2; }
        public int GetY() { return Y; }
        public int GetCenterY() { return Y + Size / 2; }
        public void Move()
        {
            Gravity();
            if (Left) { MoveLeft(); }
            if (Right) { MoveRight(); }
            if (IsJump) { MoveUp(); }
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
            }
        }
        private void MoveRight()
        {
            if (CanRight)
            {
                X += MoveSpeed;
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
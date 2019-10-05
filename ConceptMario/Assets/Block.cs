using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Shapes;

namespace ConceptMario
{
    class Block
    {
        //Blokas - turintis savo grafini blocko ivaizdi
        //turi collideri tam kad per ji negaletu pereiti žaidėjas
        private Rectangle Terrain = null;
        private Collider Col = null;
        private int Size = MetaData.Size;
        public Block(int X, int Y)
        {
            Terrain = new Rectangle();
            Terrain.Stroke = System.Windows.Media.Brushes.Black;
            Terrain.Fill = System.Windows.Media.Brushes.Red;
            Terrain.Height = Size;
            Terrain.Width = Size;
            Col = new Collider(X, Y, Size);
        }
        public Rectangle Get()
        {
            return Terrain;
        }
        /*public bool Check(int X, int Y)
        {
            return Col.ThisCollider(X, Y);
        }*/
        public bool CheckUp(int X, int Y)
        {
            return Col.CheckUp(X, Y);
        }
        public bool CheckDown(int X, int Y)
        {
            return Col.CheckDown(X, Y);
        }
        public bool CheckRight(int X, int Y)
        {
            return Col.CheckRight(X, Y);
        }
        public bool CheckLeft(int X, int Y)
        {
            return Col.CheckLeft(X, Y);
        }
        public int X() { return Col.GetX(); }
        public int Y() { return Col.GetY(); }
    }
}

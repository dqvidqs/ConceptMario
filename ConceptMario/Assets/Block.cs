using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Shapes;

namespace ConceptMario
{
    class Block : Collider
    {
        //Blokas - turintis savo grafini blocko ivaizdi
        //turi collideri tam kad per ji negaletu pereiti žaidėjas
        private Rectangle Terrain = null;
        //private Collider Col = null;
        private int Size = MetaData.Size;
        public Block(int X, int Y)
        {
            Terrain = new Rectangle();
            Terrain.Stroke = System.Windows.Media.Brushes.Black;
            Terrain.Fill = System.Windows.Media.Brushes.Red;
            Terrain.Height = Size;
            Terrain.Width = Size;
            XY[0] = X;
            XY[1] = Y;
            XX[0] = X + Size;
            XX[1] = Y;
            YY[0] = X;
            YY[1] = Y + Size;
            YX[0] = X + Size;
            YX[1] = Y + Size;
        }
        public Rectangle Get()
        {
            return Terrain;
        }
    }
}

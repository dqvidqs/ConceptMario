using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Drawing;
using System.Windows;

namespace ConceptMario
{
    class Diamond : Block
    {
        private Polygon Terrain = null;
        private int Size = MetaData.Size;
        public Diamond(int X, int Y, char Indicator)
        {
            this.Indicator = Indicator;
            XY[0] = X;
            XY[1] = Y;
            XX[0] = X + Size;
            XX[1] = Y;
            YY[0] = X;
            YY[1] = Y + Size;
            YX[0] = X + Size;
            YX[1] = Y + Size;
            Draw();
        }
        public override Polygon Get()
        {
            return Terrain;
        }
        public override void Set(Polygon Type)
        {
            throw new NotImplementedException();
        }
        public override char GetIndicator()
        {
            return Indicator;
        }
        public bool CheckCenter(int X, int Y)
        {
            if (XY[0] < X && XX[0] > X && XY[1] < Y && YY[1] > Y)
                return true;
            else
                return false;
        }
        public override int GetX() { return XY[0]; }
        public override int GetY() { return XY[1]; }

        protected override void Draw()
        {
            Terrain = new Polygon();
            Terrain.Stroke = Brushes.Black;
            Terrain.Fill = Brushes.Blue;
            //PIESIA NUO VIRSAUS I APACIA
            Terrain.Margin = new Thickness(0, 0, 0, 2);
            Terrain.Points = new PointCollection() {
                new Point(Size*1/10, Size*2/10),
                new Point(Size*2/10, Size*1/10),
                new Point(Size*8/10, Size*1/10),
                new Point(Size*9/10, Size*2/10),
                new Point(Size*9/10, Size*3/10),
                new Point(Size*5/10, Size*8/10),
                new Point(Size*1/10, Size*3/10),
            };
        }
    }
}

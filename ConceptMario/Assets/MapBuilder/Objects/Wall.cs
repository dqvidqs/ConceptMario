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
    class Wall : Block
    {
        //Wall - turintis savo grafini blocko ivaizdi
        private Polygon Terrain = null;
        private int Size = MetaData.Size;
        public Wall(int X, int Y, char Indicator)
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
        protected override void Draw()
        {
            Terrain = new Polygon();
            Terrain.Stroke = Brushes.Black;
            Terrain.Fill = Brushes.Red;
            Terrain.Points = new PointCollection() { new Point(0, 0), new Point(Size, 0), new Point(Size, Size), new Point(0, Size) };
        }
        public override void Set(Polygon Type)
        {
            Terrain = Type;
        }
        public override Polygon Get()
        {
            return Terrain;
        }
        public bool CheckUp(int X, int Y)
        {
            if (Y + Size <= XY[1])
                return true;
            else
                return false;
        }
        public bool CheckDown(int X, int Y)
        {
            if (Y <= YY[1])
                return true;
            else
                return false;
        }
        public bool CheckRight(int X, int Y)
        {
            if (X + Size <= XY[0])
                return true;
            else
                return false;
        }
        public bool CheckLeft(int X, int Y)
        {
            if (X <= XX[0])
                return true;
            else
                return false;
        }
        public override int GetX() { return XY[0]; }
        public override int GetY() { return XY[1]; }
        public override char GetIndicator()
        {
            return Indicator;
        }
    }
}

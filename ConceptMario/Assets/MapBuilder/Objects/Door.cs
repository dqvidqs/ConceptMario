using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows;

namespace ConceptMario.Assets.MapBuilder
{
    class Door : Block
    {
        private Polygon Terrain = null;
        private int Size = MetaData.Size;
        public Door(int X, int Y, char Indicator)
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

        public override int GetX() { return XY[0]; }
        public override int GetY() { return XY[1]; }

        protected override void Draw()
        {
            Terrain = new Polygon();
            Terrain.Stroke = Brushes.Black;
            Terrain.Fill = Brushes.Gray;
            //PIESIA NUO VIRSAUS I APACIA
            Terrain.Margin = new Thickness(0, 0, 0, 0);
            Terrain.Points = new PointCollection() {
                new Point(Size*1/10, Size*9/10),
                new Point(Size*9/10, Size*9/10),
                new Point(Size*9/10, 0),
                new Point(Size*1/10, 0)
            };
        }
    }
}

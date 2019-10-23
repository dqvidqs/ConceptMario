using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Drawing;
using System.Windows;


namespace ConceptMario.Assets.ShapeFactory.Shapes
{
    class DiamondShape : IShapeObjects
    {
        private Polygon Terrain = null;
        private int Size = MetaData.Size;
        public DiamondShape()
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
        public Polygon Get()
        {
            return Terrain;
        }
    }
}

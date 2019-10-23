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
    class WallShape : IShapeObjects
    {
        private Polygon Terrain = null;
        private int Size = MetaData.Size;
        public WallShape()
        {
            Terrain = new Polygon();
            Terrain.Stroke = Brushes.Black;
            Terrain.Fill = Brushes.Red;
            Terrain.Points = new PointCollection() {
                new Point(0, 0),
                new Point(Size, 0),
                new Point(Size, Size),
                new Point(0, Size)
            };
        }
        public Polygon Get()
        {
            return Terrain;
        }
    }
}

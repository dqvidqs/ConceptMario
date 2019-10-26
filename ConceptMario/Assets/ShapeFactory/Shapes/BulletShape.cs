using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows;

namespace ConceptMario.Assets.ShapeFactory.Shapes
{
    class BulletShape : IShapeObjects
    {
        private Polygon Terrain = null;
        private int Size = MetaData.Size;
        public BulletShape()
        {
            Terrain = new Polygon();
            Terrain.Stroke = Brushes.Black;
            Terrain.Fill = Brushes.Black;
            //PIESIA NUO VIRSAUS I APACIA
            Terrain.Margin = new Thickness(0, 0, 0, 10);
            Terrain.Points = new PointCollection() {
                new Point(Size*1/10, Size*3/10),
                new Point(Size*4/10, Size*3/10),
                new Point(Size*4/10, 0),
                new Point(Size*1/10, 0)
            };
        }
        public Polygon Get()
        {
            return Terrain;
        }
    }
}
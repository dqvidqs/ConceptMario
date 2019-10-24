using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows;

namespace ConceptMario.Assets.ShapeFactory.Shapes
{
    public class PlayerShape : IShapeObjects
    {
        private Polygon Terrain = null;
        private int Size = MetaData.Size;
        public PlayerShape()
        {
            Terrain = new Polygon();
            Terrain.Stroke = Brushes.Black;
            Terrain.Fill = Brushes.Green;
            //PIESIA NUO VIRSAUS I APACIA
            Terrain.Margin = new Thickness(0, 0, 0, 0);
            Terrain.Points = new PointCollection() {
                new Point(0, Size*1/2),
                new Point(Size*1/2, 0),
                new Point(Size, Size*1/2),
                new Point(Size*1/2, Size)
            };
        }
        public Polygon Get()
        {
            return Terrain;
        }
    }
}

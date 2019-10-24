using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows;

namespace ConceptMario.Assets.ShapeFactory.Shapes
{
    public class DoorShape : IShapeObjects
    {
        private Polygon Terrain = null;
        private int Size = MetaData.Size;
        public DoorShape()
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
        public Polygon Get()
        {
            return Terrain;
        }
    }
}

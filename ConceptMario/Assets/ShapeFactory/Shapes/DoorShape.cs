using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows;
using ConceptMario.Assets.ShapeFactory.Color;

namespace ConceptMario.Assets.ShapeFactory.Shapes
{
    public class DoorShape : IShapeObjects
    {
        public DoorShape(IColor Stroke, IColor Fill) : base(Stroke, Fill)
        {
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

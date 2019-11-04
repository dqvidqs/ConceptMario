using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows;
using ConceptMario.Assets.ShapeFactory.Color;

namespace ConceptMario.Assets.ShapeFactory.Shapes
{
    public class PlayerShape : IShapeObjects
    {
        public PlayerShape(IColor Stroke, IColor Fill) : base(Stroke, Fill)
        {
            //PIESIA NUO VIRSAUS I APACIA
            Terrain.Margin = new Thickness(0, 0, 0, 0);
            Terrain.Points = new PointCollection() {
                new Point(0, Size*1/2),
                new Point(Size*1/2, 0),
                new Point(Size, Size*1/2),
                new Point(Size*1/2, Size)
            };
        }
    }
}

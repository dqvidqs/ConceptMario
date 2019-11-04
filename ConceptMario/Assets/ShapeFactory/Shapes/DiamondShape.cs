using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows;
using ConceptMario.Assets.ShapeFactory.Color;

namespace ConceptMario.Assets.ShapeFactory.Shapes
{
    public class DiamondShape : IShapeObjects
    {
        public DiamondShape(IColor Stroke, IColor Fill) : base(Stroke, Fill)
        {
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

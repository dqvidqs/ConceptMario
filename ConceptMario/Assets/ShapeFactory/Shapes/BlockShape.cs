using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows;
using ConceptMario.Assets.ShapeFactory.Color;

namespace ConceptMario.Assets.ShapeFactory.Shapes
{
    public class BlockShape : IShapeObjects
    {
        public BlockShape(IColor Stroke, IColor Fill) : base(Stroke, Fill)
        {
            Terrain.Points = new PointCollection() {
                new Point(0, 0),
                new Point(Size, 0),
                new Point(Size, Size),
                new Point(0, Size)
            };
        }
    }
}

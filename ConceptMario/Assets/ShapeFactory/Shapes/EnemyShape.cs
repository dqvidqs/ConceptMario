using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows;
using ConceptMario.Assets.ShapeFactory.Color;

namespace ConceptMario.Assets.ShapeFactory.Shapes
{
    public class EnemyShape : ObjectShape
    {
        public EnemyShape(IColor Fill) : base(Fill)
        {
            //PIESIA NUO VIRSAUS I APACIA
            Terrain.Margin = new Thickness(0, 0, 0, 0);
            Terrain.Points = new PointCollection() {
                new Point(0, 0),
                new Point(0, Size),
                new Point(Size, Size),
                new Point(Size, 0),
                new Point(Size*3/4, Size*1/3),
                new Point(Size*2/4, 0),
                new Point(Size*1/4, Size*1/3),
            };
        }
    }
}

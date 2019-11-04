using System.Windows.Shapes;
using ConceptMario.Assets.ShapeFactory.Color;

namespace ConceptMario.Assets.ShapeFactory.Shapes
{
    public abstract class IShapeObjects
    {
        protected Polygon Terrain = null;
        protected int Size = MetaData.Size;
        public IShapeObjects(IColor Stroke, IColor Fill)
        {
            Terrain = new Polygon();
            Terrain.Stroke = Stroke.Get();
            Terrain.Fill = Fill.Get();
        }
        public Polygon Get()
        {
            return Terrain;
        }
    }
}

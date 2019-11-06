using System.Windows.Shapes;
using ConceptMario.Assets.ShapeFactory.Color;

namespace ConceptMario.Assets.ShapeFactory.Shapes
{
    public abstract class ObjectShape
    {
        protected IColor Fill;
        protected Polygon Terrain;
        protected int Size = MetaData.Size;
        public ObjectShape(IColor Fill)
        {
            this.Fill = Fill;
            Terrain = new Polygon();
            Terrain.Stroke = new Black().Get();
        }
        public Polygon Get()
        {
            Terrain.Fill = Fill.Get();
            return Terrain;
        }
    }
}

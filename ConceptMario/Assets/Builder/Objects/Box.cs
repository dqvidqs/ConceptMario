using System.Windows.Shapes;

namespace ConceptMario.Assets.MapBuilder.Objects
{
    public class Box : Wall
    {
        //public Box() : base() { }
        public Box(int X, int Y, Polygon Terrain) : base(X, Y, Terrain) { }
       
    }
}

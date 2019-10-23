using System.Windows.Shapes;

namespace ConceptMario.Assets.MapBuilder.Objects
{
    class Diamond : Block
    {
        public Diamond(int X, int Y, Polygon Terrain) : base(X, Y, Terrain) { }
        public bool CheckCenter(int X, int Y)
        {
            if (XY[0] < X && XY[0] + Size > X && XY[1] < Y && XY[1] + Size > Y)
                return true;
            else
                return false;
        }
    }
}


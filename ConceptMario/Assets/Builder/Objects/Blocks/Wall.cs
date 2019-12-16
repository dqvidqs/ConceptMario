using System.Windows.Shapes;

namespace ConceptMario.Assets.Builder.Objects
{
    public class Wall : Block
    {
        public Wall(int X, int Y, Polygon Terrain) : base(X, Y, Terrain) { }
        public bool CheckUp(int Y)
        {
            if (Y + Size <= XY[1])
                return true;
            else
                return false;
        }
        public bool CheckDown(int Y)
        {
            if (Y <= XY[1] + Size)
                return true;
            else
                return false;
        }
        public bool CheckRight(int X)
        {
            if (X + Size <= XY[0])
                return true;
            else
                return false;
        }
        public bool CheckLeft(int X)
        {
            if (X <= YX[0])
                return true;
            else
                return false;
        }
      
    }
}
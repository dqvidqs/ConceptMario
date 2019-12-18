using System.Windows.Shapes;

namespace ConceptMario.Assets.Builder.Objects
{
    public class Diamond : Block
    {
        public int Coin { get; set; }
        //public Diamond() : base() { }
        public Diamond(int X, int Y, Polygon Terrain) : base(X, Y, Terrain)
        {
            Coin = 10;
        }

    }
}


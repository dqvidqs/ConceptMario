using System.Windows.Shapes;

namespace ConceptMario.Assets.MapBuilder.Objects
{
    abstract class Block
    {
        // YY --- YX
        // |       |
        // |       |
        // XY --- XX
        protected int[] XY = new int[2];
        protected int[] YX = new int[2];
        protected int Size = MetaData.Size;
        protected Polygon Terrain = new Polygon();
        public Block(int X, int Y, Polygon Terrain)
        {
            XY[0] = X;
            XY[1] = Y;
            YX[0] = X + Size;
            YX[1] = Y + Size;
            this.Terrain = Terrain;
        }
        public Polygon Get()
        {
            return Terrain;
        }
        public int GetX() { return XY[0]; }
        public int GetY() { return XY[1]; }
    }
}

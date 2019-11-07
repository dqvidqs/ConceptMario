using System.Windows.Shapes;

namespace ConceptMario.Assets.MapBuilder.Objects
{
    public class Enemy : Block
    {
        private int _direction = 1;
        private int _speed = 1;
        public int Direction { get { return _direction; } set { _direction = value; } }
        //public Enemy() : base() { }
        public Enemy(int X, int Y, Polygon Terrain) : base(X, Y, Terrain) { }
        public void Move()
        {
            XY[0] += _speed * _direction;
            YX[0] += _speed * _direction;
        }
        /*public int GetXGridNext()
        {
            return (XY[0] + Size) / Size;
        }*/
    }
}

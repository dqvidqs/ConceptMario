using System.Windows.Shapes;

namespace ConceptMario.Assets.Builder.Objects
{
    public abstract class Enemy : Block
    {
        protected int _hitPoint;
        public int  HP { get { return _hitPoint; } }
        private int _direction = 1;
        private int _speed = 1;
        public int Direction { get { return _direction; } set { _direction = value; } }
        public Enemy() : base(-1, -1, null) { TemplateMethod(); }
        public void Move()
        {
            XY[0] += _speed * _direction;
            YX[0] += _speed * _direction;
        }
        /*public int GetXGridNext()
        {
            return (XY[0] + Size) / Size;
        }*/
        private void TemplateMethod()
        {
            SetPolygon();
            SetHP();
        }

        protected abstract void SetPolygon();
        protected abstract void SetHP();
        public bool Damage(int Damage)
        {
            _hitPoint -= Damage;
            if (_hitPoint <= 0)
            {
                return true;
            }
            return false;
        }
        public void SetCoordantes(int X, int Y)
        {
            XY[0] = X;
            XY[1] = Y;
            YX[0] = X + Size;
            YX[1] = Y + Size;
        }
    }
}

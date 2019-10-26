using System.Windows.Shapes;

namespace ConceptMario.Assets.Characters.PlayerAssets
{
    public class Bullet
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Polygon bullet { get; set; }
        public int Direction { get; set; }
        public int BulletSpeed { get; set; }
    }
}

using System.Windows.Shapes;
namespace Objects.Characters.PlayerAssets
{
    public class BulletData
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Direction { get; set; }
        public int BulletSpeed { get; set; }
        public Polygon Bullet { get; set; }
    }
}

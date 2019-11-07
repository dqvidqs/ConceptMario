
using ConceptMario.Assets.Characters.PlayerAssets;
using System.Windows.Shapes;

namespace ConceptMario
{
    public class Bullet
    {
        public Polygon bullet { get; set; }
        public BulletData data { get; set; }

        public Bullet(BulletData data, Polygon polygon)
        {
            this.data = data;
            bullet = polygon;
        }
    }
}

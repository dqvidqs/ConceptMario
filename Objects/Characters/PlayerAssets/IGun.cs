
using Objects.Enums;

namespace Objects.Characters.PlayerAssets
{
    public interface IGun
    {
        void Update();
        BulletData Shoot(int x, int y, Directions direction);
        void Relaod();
    }
}

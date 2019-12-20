using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Collections.Generic;
using ConceptMario.Assets.ShapeFactory;
using Objects.Characters.PlayerAssets;
using Objects.Characters.PlayerAssets.Guns;
using System.Linq;
using Objects.Enums;
using Objects.Decorator;
using System;

namespace ConceptMario.Assets.Characters
{
    /*
     *Player interfeisasas
     */
    interface IPlayer
    {
        void Update(int X, int Y);
        void Update();
        List<BulletData> GetBullet();
        void RemoveBullet(int i);
        Polygon Get();
        void Set();
        int GetX();
        int GetCenterX();
        int GetY();
        int GetCenterY();
        void Reload();
        void Move();
        void Shooting();

        void Gravity();
        void MoveLeft();
        void MoveRight();
        void MoveUp();
    }
}

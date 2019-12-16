using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConceptMario.Assets.Builder.Objects;
using ConceptMario.Assets.ShapeFactory;

namespace ConceptMario.Assets.TemplateMethod
{
    class RedEnemy : Enemy
    {
        public RedEnemy() : base() { }
        protected override void SetHP()
        {
            _hitPoint = 150;
        }

        protected override void SetPolygon()
        {
            Terrain = Factory.GetShape("enemy-red").Get();
        }
    }
}

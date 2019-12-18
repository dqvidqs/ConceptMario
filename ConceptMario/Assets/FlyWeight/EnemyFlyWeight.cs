using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConceptMario.Assets.Builder.Objects;
using ConceptMario.Assets.TemplateMethod;

namespace ConceptMario.Assets.FlyWeight
{
    static class EnemyFlyWeight
    {
        private static Dictionary<string, Enemy> EnemyList = new Dictionary<string, Enemy>();
        public static Enemy GetEnemy(string Color)
        {
            if (EnemyList.ContainsKey(Color))
            {
                return EnemyList[Color];
            }
            switch (Color)
            {
                case "yellow":
                    EnemyList.Add(Color, new YellowEnemy());
                    break;
                case "red":
                    EnemyList.Add(Color, new RedEnemy());
                    break;
            }
            return EnemyList[Color];
        }
    }
}

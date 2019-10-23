using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows;

namespace ConceptMario.Assets.MapBuilder
{
    class Door : Block
    {
        public Door(int X, int Y, Polygon Terrain) : base(X, Y, Terrain) { }
    }
}

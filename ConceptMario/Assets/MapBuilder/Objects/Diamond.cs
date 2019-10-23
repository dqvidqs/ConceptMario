using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Drawing;
using System.Windows;

namespace ConceptMario
{
    class Diamond : Block
    {
        public Diamond(int X, int Y, Polygon Terrain) : base(X, Y, Terrain) { }
        public bool CheckCenter(int X, int Y)
        {
            if (XY[0] < X && XY[0] + Size > X && XY[1] < Y && XY[1] + Size > Y)
                return true;
            else
                return false;
        }
    }
}


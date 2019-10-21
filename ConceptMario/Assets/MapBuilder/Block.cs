using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Shapes;

namespace ConceptMario
{
    abstract class Block
    {
        // YY --- YX
        // |       |
        // |       |
        // XY --- XX
        protected int[] XX = new int[2];
        protected int[] XY = new int[2];
        protected int[] YX = new int[2];
        protected int[] YY = new int[2];
        protected abstract void Draw();
        protected char Indicator;
        public abstract Polygon Get();
        public abstract char GetIndicator();
        public abstract int GetX();
        public abstract int GetY();
    }
}

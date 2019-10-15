using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptMario
{
    class Collider
    {
        // YY --- YX
        // |       |
        // |       |
        // XY --- XX
        protected int[] XX = new int[2];
        protected int[] XY = new int[2];
        protected int[] YX = new int[2];
        protected int[] YY = new int[2];

        public bool CheckUp(int X, int Y)
        {
            if (Y + MetaData.Size <= XY[1])
                return true;
            else
                return false;
        }
        public bool CheckDown(int X, int Y)
        {
            if (Y <= YY[1])
                return true;
            else
                return false;
        }
        /*public bool ThisCollider(int X, int Y)
        {
            if (X >= XY[0] && X <= XX[1] && 15 >= Y - YY[1])
                return true;
            else
                return false;
        }*/
        public bool CheckRight(int X, int Y)
        {
            if (X + MetaData.Size <= XY[0])
                return true;
            else
                return false;
        }
        public bool CheckLeft(int X, int Y)
        {
            if (X <= XX[0])
                return true;
            else
                return false;
        }
        public int GetX() { return XY[0]; }
        public int GetY() { return XY[1]; }
    }
}
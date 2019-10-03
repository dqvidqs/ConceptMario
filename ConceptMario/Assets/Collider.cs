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
        private int[] XX = new int[2];
        private int[] XY = new int[2];
        private int[] YX = new int[2];
        private int[] YY = new int[2];
        public Collider(int X, int Y, int Size)
        {
            XY[0] = X;
            XY[1] = Y;
            XX[0] = X + Size;
            XX[1] = Y;
            YY[0] = X;
            YY[1] = Y + Size;
            YX[0] = X + Size;
            YX[1] = Y + Size;
        }
        public bool CheckUp(int X, int Y)
        {
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
            if (X + 25 <= XY[0])
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
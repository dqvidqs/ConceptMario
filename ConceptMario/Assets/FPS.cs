using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptMario
{
    static class FPS
    {
        public static double GetSecByFrames(double Frames)
        {
            return 1 / Frames;
        }
    }
}

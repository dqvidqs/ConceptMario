using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptMario.Assets.Interpreter
{
    public class Context
    {
        public string Data { get; set; }
        private int _length = 0;
        private string[] Line;
        public void Split()
        {
            Line = Data.Split(' ');
            _length = Line.Length;
        }
        public string Get(int index)
        {
            if(index >= 0 && index < _length)
            {
                return Line[index];
            }
            else
            {
                Split();
                return Get(index);
            }
        }
    }
}

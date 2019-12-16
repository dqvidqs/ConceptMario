using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConceptMario.Assets.Builder.Objects;
namespace ConceptMario.Assets.Iterator
{
    public class MapObjectIterator : IIterator
    {
        private Block[] Blocks = null;
        private int MAX;
        private int index = 0;
        public MapObjectIterator(Block[] Blocks)
        {
            this.Blocks = Blocks;
            MAX = Blocks.Length;
        }
        public bool HasNext()
        {
            if (Blocks[index] != null)
                return true;
            else
                return false;
        }

        public object Next()
        {
            if (HasNext())
            {
                return Blocks[index++];
            }
            return null;
        }
    }
}

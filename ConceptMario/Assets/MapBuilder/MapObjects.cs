using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptMario
{
    class MapObjects
    {
        private List<Block> Blocks = new List<Block>();
        public void AddBock(Block block)
        {
            Blocks.Add(block);
        }
        public List<Block> GetBlocks()
        {
            return Blocks;
        }
        public int Count { get { return Blocks.Count; } }
    }
}

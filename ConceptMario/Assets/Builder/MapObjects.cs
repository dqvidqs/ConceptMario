using System.Collections.Generic;
using ConceptMario.Assets.MapBuilder.Objects;

namespace ConceptMario.Assets.MapBuilder
{
    public class MapObjects
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
    }
}

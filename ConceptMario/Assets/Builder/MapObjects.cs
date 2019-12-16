using System.Collections.Generic;
using ConceptMario.Assets.Builder.Objects;

namespace ConceptMario.Assets.Builder
{
    public class MapObjects
    {
        private List<Block> Objects = new List<Block>();
        public void AddBlock(Block Objects)
        {
            if (!this.Objects.Contains(Objects))
            {
                this.Objects.Add(Objects);
            }
        }
        public int Count { get { return Objects.Count; } }
        public Block this[int index] { get { return Objects[index]; } }
    }
}

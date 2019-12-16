using System.Collections.Generic;
using ConceptMario.Assets.Builder.Objects;
using ConceptMario.Assets.Iterator;

namespace ConceptMario.Assets.Builder
{
    public class MapObjects : ICollection
    {
        private int MAX = 864;
        private int index = 0;
        private Block[] Objects = null;
        public MapObjects()
        {
            Objects = new Block[MAX];
        }
        public void AddBlock(Block Object)
        {
            if(index < MAX)
            {
                Objects[index++] = Object;
            }
        }

        public IIterator CreateIterator()
        {
            return new MapObjectIterator(Objects);
        }
        //public int Count { get { return Objects.Count; } }
        //public Block this[int index] { get { return Objects[index]; } }
    }
}

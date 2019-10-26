using System.Collections.Generic;
using ConceptMario.Assets.MapBuilder.Objects;

namespace ConceptMario.Assets.MapBuilder
{
    class MapDirector
    {
        private IMapBuilder mapBuilder;
        public MapDirector(IMapBuilder mapBuilder)
        {
            this.mapBuilder = mapBuilder;
        }
        public void Construct()
        {
            mapBuilder.BuildDiamonds();
            mapBuilder.BuildWalls();
            mapBuilder.BuilDoors();
            mapBuilder.BuilBoxes();
        }
        public List<Block> GetBlocks()
        {
            return mapBuilder.GetBlocks();
        }
    }
}

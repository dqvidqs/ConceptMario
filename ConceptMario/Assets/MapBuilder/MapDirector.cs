using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConceptMario.Assets.MapBuilder;

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
        }
        public List<Block> GetBlocks()
        {
            return mapBuilder.GetBlocks();
        }
    }
}

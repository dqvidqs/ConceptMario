using System.Collections.Generic;
using ConceptMario.Assets.Builder.Objects;

namespace ConceptMario.Assets.Builder
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
            mapBuilder.BuildDoors();
            mapBuilder.BuildBoxes();
            mapBuilder.BuildEnemies();
        }
    }
}

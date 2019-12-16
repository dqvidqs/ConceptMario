using System.Collections.Generic;
using ConceptMario.Assets.Builder.Objects;

namespace ConceptMario.Assets.Builder
{
    interface IMapBuilder
    {
        void BuildWalls();

        void BuildDiamonds();

        void BuildDoors();

        void BuildBoxes();

        void BuildEnemies();

        MapObjects GetResult();
    }
}

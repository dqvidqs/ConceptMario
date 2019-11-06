﻿using System.Collections.Generic;
using ConceptMario.Assets.MapBuilder.Objects;

namespace ConceptMario.Assets.MapBuilder
{
    interface IMapBuilder
    {
        string Grid { set; get; }
        void BuildWalls();

        void BuildDiamonds();

        void BuildDoors();

        void BuildBoxes();

        void BuildEnemies();

        List<Block> GetBlocks();
    }
}

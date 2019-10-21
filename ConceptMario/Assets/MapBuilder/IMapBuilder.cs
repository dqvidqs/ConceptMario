using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptMario.Assets.MapBuilder
{
    interface IMapBuilder
    {
        void BuildWalls();

        void BuildDiamonds();

        List<Block> GetBlocks();
    }
}

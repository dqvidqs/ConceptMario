using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConceptMario.Assets.MapBuilder;

namespace ConceptMario.Assets.MapBuilder
{
    //Builder
    class MapBuilder : IMapBuilder
    {
        private MapObjects obj;
        private string Grid;
        private int Step;
        private int Width = MetaData.Width;
        private int Size = MetaData.Size;
        public MapBuilder(string Grid)
        {
            obj = new MapObjects();
            this.Grid = Grid;
        }
        public void BuildDiamonds()
        {
            Step = 0;
            for (int i = 0; i < Grid.Length; i++)
            {
                if (Grid[i] == '1')
                {
                    obj.AddBock(new Wall(i % Width * Size, Step * Size, '1'));
                }
                if ((i + 1) % Width == 0 && i != 0)
                {
                    Step++;
                }
            }
        }

        public void BuildWalls()
        {
            Step = 0;
            for (int i = 0; i < Grid.Length; i++)
            {
                if (Grid[i] == '2')
                {
                    obj.AddBock(new Diamond(i % Width * Size, Step * Size, '2'));
                }
                if ((i + 1) % Width == 0 && i != 0)
                {
                    Step++;
                }
            }
        }
        public List<Block> GetBlocks()
        {
            return obj.GetBlocks();
        }
    }
}
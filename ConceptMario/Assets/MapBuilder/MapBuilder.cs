using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptMario
{
    class MapBuilder
    {
        private int Height;
        private int Width;
        private int Size;
        private int Step = 0;
        public MapBuilder(int Width, int Height, int Size)
        {
            this.Height = Height;
            this.Width = Width;
            this.Size = Size;
        }
        public MapObjects PrepareWalls(string GridMap)
        {
            Step = 0;
            MapObjects obj = new MapObjects();
            for (int i = 0; i < GridMap.Length; i++)
            {
                if(GridMap[i] == '1')
                {
                    obj.AddBock(new Wall(i % Width * Size, Step * Size, '1'));
                }
                if ((i + 1) % Width == 0 && i != 0)
                {
                    Step++;
                }
            }
            return obj;
        }
        public MapObjects PrepareDiamons(string GridMap)
        {
            Step = 0;
            MapObjects obj = new MapObjects();
            for (int i = 0; i < GridMap.Length; i++)
            {
                if (GridMap[i] == '2')
                {
                    obj.AddBock(new Diamond(i % Width * Size, Step * Size, '2'));
                }
                if ((i + 1) % Width == 0 && i != 0)
                {
                    Step++;
                }
            }
            return obj;
        }
    }
}
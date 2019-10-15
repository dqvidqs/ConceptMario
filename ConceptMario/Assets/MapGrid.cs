using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptMario
{
    class MapGrid
    {
        private Block[,] _grid;
        private int Width = MetaData.Width;
        public int W { get { return Width; } }
        private int Height = MetaData.Height;
        public int H { get { return Height; } }
        private int Size = MetaData.Size;
        public int S { get { return Size; } }

        public MapGrid(int MapID)
        {
            switch (MapID)
            {
                case 0:
                    BuildMap(_0GRID);
                    break;
            }
        }
        public Block GetBlock(int X,int Y)
        {
            if (_grid[X, Y] != null)
            {
                return _grid[X, Y];
            }
            else { return null; }
        }
        public Block[] FindNearByPlayer(Player Player)
        {
            int Sides = 4;
            Block[] Blocks = new Block[Sides];
            Blocks[0] = _grid[ Player.GetY() / Size + 1, Player.GetX() / Size];//UP
            Blocks[1] = _grid[ Player.GetY() / Size,Player.GetX() / Size + 1];//RIGHT
            Blocks[2] = _grid[ Player.GetY() / Size - 1, Player.GetCenterX() / Size];//DOWN
            Blocks[3] = _grid[ Player.GetY() / Size, Player.GetX() / Size - 1];//LEFT
            return Blocks;
        }
        public void BuildMap(string Grid)
        {
            _grid = new Block[Height, Width];//Heigh;Width; or y;x;

            int Step = 0;
            for (int i = 0; i < Grid.Length; i++)
            {
                if (Grid[i] == '1')
                {
                    _grid[Step, i % Width] = new Block(i % Width * Size, Step * Size);
                }
                if ((i + 1) % Width == 0 && i != 0)
                {
                    Step++;
                }
            }
        }
        //MAPAS GENERUOJAMAS PAGAL STRING
        //ATVIRKSCIAS
        //JEI VIRSUS TAI BUS APACIA
        //PVZ 1 = blockas
        private string _0GRID = "" +
            "111111111111111111111111111111111111" +
            "100000100000000000000000000000000001" +
            "100001100000000000000000000000000001" +
            "100000100000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "111111111111111111111111111111111111";

    }
}

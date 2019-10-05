using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptMario
{
    class MapGrid
    {
        private Block[,] _Grid;
        private int Width = MetaData.Width;
        public int W { get { return Width; } }
        private int Height = MetaData.Height;
        public int H { get { return Height; } }
        private int Size = MetaData.Size;
        public int S { get { return Size; } }
        /*public MapGrid(int Width, int Height, int Size)
        {
            this.Height = Height;
            this.Width = Width;
            this.Size = Size;
            _Grid = new Block[Width / Size, Width / Size];//Heigh;Width;
        }*/
        public MapGrid()
        {
            _Grid = new Block[Width, Width];//Heigh;Width;
            //int l = _0GRID.Length;
            int Step = 0;
            for (int i = 0; i < _0GRID.Length; i++)
            {
                if (_0GRID[i] == '1')
                {
                    int test0 = i % Width;
                    int test1 = Step;
                    _Grid[Step, i % Width] = new Block(i % Width * Size, Step * Size);
                }
                if (i % Width == 0 && i != 0)
                {
                    Step++;
                }
            }
        }
        public Block GetBlock(int X,int Y)
        {
            if (_Grid[X, Y] != null)
            {
                return _Grid[X, Y];
            }
            else { return null; }
        }
        public Block[] FindNearByPlayer(Player Player)
        {
            int Sides = 4;
            Block[] Blocks = new Block[Sides];
            int test0 = Player.GetX() / Size;
            int test1 = Player.GetY() / Size + 1;
            int test2 = Player.GetX() / Size + 1;
            int test3 = Player.GetY() / Size;
            int test4 = Player.GetX() / Size;
            int test5 = Player.GetY() / Size - 1;
            int test6 = Player.GetX() / Size - 1;
            int test7 = Player.GetY() / Size;
            Blocks[0] = _Grid[ Player.GetY() / Size + 1, Player.GetX() / Size];//UP
            Blocks[1] = _Grid[ Player.GetY() / Size,Player.GetX() / Size + 1];//RIGHT
            Blocks[2] = _Grid[ Player.GetY() / Size - 1, Player.GetCenterX() / Size];//DOWN
            Blocks[3] = _Grid[ Player.GetY() / Size, Player.GetX() / Size - 1];//LEFT
            return Blocks;
        }
        //MAPAS GENERUOJAMAS PAGAL STRING
        //ATVIRKSCIAS
        //JEI VIRSUS TAI BUS APACIA
        //PVZ 1 = blockas
        private string _0GRID = "" +
            "111111111111111111111111111111111111" +
            "100000100000000000000000000000000001" +
            "000001100000000000000000000000000000" +
            "000000100000000000000000000000000000" +
            "000000000000000000000000000000000000" +
            "000000000000000000000000000000000000" +
            "000000000000000000000000000000000000" +
            "000000000000000000000000000000000000" +
            "000000000000000000000000000000000000" +
            "000000000000000000000000000000000000" +
            "000000000000000000000000000000000000" +
            "000000000000000000000000000000000000" +
            "000000000000000000000000000000000000" +
            "000000000000000000000000000000000000" +
            "000000000000000000000000000000000000" +
            "000000000000000000000000000000000000" +
            "000000000000000000000000000000000000" +
            "000000000000000000000000000000000000" +
            "000000000000000000000000000000000000" +
            "000000000000000000000000000000000000" +
            "000000000000000000000000000000000000" +
            "000000000000000000000000000000000000" +
            "000000000000000000000000000000000000" +
            "000000000000000000000000000000000000";

    }
}

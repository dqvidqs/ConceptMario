﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptMario
{
    class MapGrid
    {
        private object[,] _grid;
        private int Width = MetaData.Width;
        public int W { get { return Width; } }
        private int Height = MetaData.Height;
        public int H { get { return Height; } }
        private int Size = MetaData.Size;
        public int S { get { return Size; } }

        public MapGrid(int MapID)
        {
            MapBuilder Builder = new MapBuilder(W, H, S);
            _grid = new object[Height, Width];
            MapObjects objWalls = null;
            MapObjects objDiamonds = null;
            switch (MapID)
            {
                case 0:
                    objWalls = Builder.PrepareWalls(_0GRID);
                    objDiamonds = Builder.PrepareDiamons(_0GRID);
                    break;
            }
            
            BuildMap(objWalls.GetBlocks());
            BuildMap(objDiamonds.GetBlocks());
            objWalls = null;
            objDiamonds = null;
            Builder = null;
        }
        public object GetBlock(int X, int Y)
        {
            return _grid[Y, X];
        }
        public Wall[] FindNearByPlayer(Player Player)
        {
            int Sides = 4;
            Wall[] Blocks = new Wall[Sides];
            Blocks[0] = _grid[Player.GetY() / Size + 1, Player.GetX() / Size] as Wall;//UP
            Blocks[1] = _grid[Player.GetY() / Size, Player.GetX() / Size + 1] as Wall;//RIGHT
            Blocks[2] = _grid[Player.GetY() / Size - 1, Player.GetCenterX() / Size] as Wall;//DOWN
            Blocks[3] = _grid[Player.GetY() / Size, Player.GetX() / Size - 1] as Wall;//LEFT
            return Blocks;
        }
        public void BuildMap(List<Block> Blocks)
        {
            foreach (Block block in Blocks)
            {
                _grid[block.GetY() / Size, block.GetX() / Size] = block ;
            }
        }
        public void Remove(int X, int Y)
        {
            _grid[Y / Size, X / Size] = null;
        }
        //MAPAS GENERUOJAMAS PAGAL STRING
        //ATVIRKSCIAS
        //JEI VIRSUS TAI BUS APACIA
        //1 = Wall
        //2 = Diamond
        private string _0GRID = "" +
            "111111111111111111111111111111111111" +
            "100002100000000000000000000000000001" +
            "100001100000000000000000000000000001" +
            "100000100000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "100000000000000000000000000000000001" +
            "100000000000000000020000000000000001" +
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
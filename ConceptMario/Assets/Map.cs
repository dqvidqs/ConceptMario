using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;

namespace ConceptMario
{
    class Map
    {
        private Canvas Can = null;
        // private Block[] Blocks = null;
        private MapGrid Grid = new MapGrid();
        public Map(Player player)
        {
            Can = new Canvas();
            Can.Background = Brushes.AliceBlue;
            Can.Height = 600;
            Can.Width = 900;
            Can.Margin = new System.Windows.Thickness(0, 0, 0, 0);
            SetupBlock();
            Can.Children.Add(player.Get());
            Canvas.SetBottom(player.Get(), player.GetY());
            Canvas.SetLeft(player.Get(), player.GetX());
        }
        public Canvas Get()
        {
            return Can;
        }
        public void UpdatePlayer(Player Player)
        {
            //4 nes, UP, RIGHT,DOWN, LEFT
            Block[] Blocks = Grid.FindNearByPlayer(Player);

            //DOWN
            if (Blocks[2] != null)
            {
                if (Blocks[2].CheckDown(Player.GetCenterX(), Player.GetY()))
                { Player.CanJump = true; }
                else { Player.CanJump = false; }
            }
            else { Player.CanJump = false; }
            //RIGHT
            if (Blocks[1] != null)
            {
                if (Blocks[1].CheckRight(Player.GetX(), Player.GetY()))
                { Player.CanRight = false; }
                else { Player.CanRight = true; }
            }
            else { Player.CanRight = true; }
            //LEFT
            if (Blocks[3] != null)
            {
                if (Blocks[3].CheckLeft(Player.GetX(), Player.GetY()))
                { Player.CanLeft = false; }
                else { Player.CanLeft = true; }
            }
            else { Player.CanLeft = true; }
            /*if (Blocks[3] != null)
            {
                if (Blocks[3].CheckUp(Player.GetX(), Player.GetY()))
                { Player.CanJump = false; }
                else { Player.CanJump = true; }
            }
            if (Blocks[3] != null)
            {
                if (Blocks[3].CheckUp(Player.GetX(), Player.GetY()))
                { Player.CanJump = false; }
                else { Player.CanJump = true; }
            }*/
            //jei null reiskia salia nera :D

            /*int index = -1;
            bool status = false;
            for (int i = 0; i < Blocks.Length; i++)
            {
                status = Blocks[i].Check(player.GetX(), player.GetY());
                if (status)
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                if (Blocks[index].CheckUp(player.GetX(), player.GetY()))
                { player.CanJump = false; }
                else { player.CanJump = true; }
            }
            else { player.CanJump = false; }*/
            Canvas.SetBottom(Player.Get(), Player.GetY());
            Canvas.SetLeft(Player.Get(), Player.GetX());
        }
        // ---------- PRIVATE ----------
        private void SetupBlock()
        {
            for (int i = 0; i < Grid.H; i++)
            {
                for (int j = 0; j < Grid.W; j++)
                {
                    if (Grid.GetBlock(i, j) != null)
                    {
                        Can.Children.Add(Grid.GetBlock(i, j).Get());
                        Canvas.SetBottom(Grid.GetBlock(i, j).Get(), Grid.GetBlock(i, j).Y());
                        Canvas.SetLeft(Grid.GetBlock(i, j).Get(), Grid.GetBlock(i, j).X());
                    }
                }
            }
        }
    }
}
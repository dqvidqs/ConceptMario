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
        private MapGrid Grid = null;
        private int  Size = MetaData.Size;
        public Map(Player player1, Player player2, int MapId)
        {
            Grid = new MapGrid(MapId);
            Can = new Canvas();
            Can.Background = Brushes.AliceBlue;
            Can.Height = MetaData.HeightPx;
            Can.Width = MetaData.WidthPx;
            Can.Margin = new System.Windows.Thickness(0, 0, 0, 0);
            SetupBlock();
            Can.Children.Add(player1.Get());
            Canvas.SetBottom(player1.Get(), player1.GetY());
            Canvas.SetLeft(player1.Get(), player1.GetX());
			Can.Children.Add(player2.Get());
			Canvas.SetBottom(player2.Get(), player2.GetY());
			Canvas.SetLeft(player2.Get(), player2.GetX());           
        }
        public Canvas Get()
        {
            return Can;
        }
        public void UpdatePlayer(Player Player)
        {
            PlayerMovements(Player);
            CatchDiamond(Player);
            Canvas.SetBottom(Player.Get(), Player.GetY());
            Canvas.SetLeft(Player.Get(), Player.GetX());           
        }
        // ---------- PRIVATE ----------
        private void PlayerMovements(Player Player)
        {
            //4 nes, UP, RIGHT,DOWN, LEFT
            Wall[] Blocks = Grid.FindNearByPlayer(Player);
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
        }
        private void CatchDiamond(Player Player)
        {
            Diamond diamond = Grid.GetBlock(Player.GetCenterX() / Size, Player.GetCenterY() / Size) as Diamond;
            if (diamond != null)
            {
                int index = Can.Children.IndexOf(diamond.Get());
                Can.Children.RemoveAt(index);
                Grid.Remove(Player.GetCenterX(), Player.GetCenterY());
            }
        }
        private void SetupBlock()
        {
            for (int i = 0; i < Grid.H; i++)
            {
                for (int j = 0; j < Grid.W; j++)
                {
                    if (Grid.GetBlock(j, i) != null)
                    {
                        Block block = Grid.GetBlock(j, i) as Block;
                        Can.Children.Add(block.Get());
                        Canvas.SetBottom(block.Get(), block.GetY());
                        Canvas.SetLeft(block.Get(), block.GetX());
                    }
                }
            }
        }
    }
}
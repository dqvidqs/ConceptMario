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
        private Block[] Blocks = null;
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
        public void UpdatePlayer(Player player)
        {
            int index = -1;
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
            else { player.CanJump = false; }
            Canvas.SetBottom(player.Get(), player.GetY());
            Canvas.SetLeft(player.Get(), player.GetX());
        }
        // ---------- PRIVATE ----------
        private int[] Coordinates = { 0, 0, 25, 0, 50, 0, 75, 0, 100, 0, 125, 0, 150, 0, 175, 0, 200, 0, 225, 0, 250, 0, 275, 0, 300, 0, 325, 0, 350, 0, 375, 0, 400, 0, 425, 0, 450, 0, 475, 0, 500, 0, 525, 0, 550, 0, 575, 0, 0, 50, 25, 50, 50, 50, 75, 50, 100, 50 };
        private void SetupBlock()
        {
            int j = 0;
            Blocks = new Block[Coordinates.Length / 2];
            for (int i = 0; i < Coordinates.Length; i += 2)
            {
                Block B = new Block(Coordinates[i], Coordinates[i + 1]);
                Blocks[j++] = B;
                Can.Children.Add(B.Get());
                Canvas.SetBottom(B.Get(), B.Y());
                Canvas.SetLeft(B.Get(), B.X());
            }
        }
    }
}
using System.Windows.Media;
using System.Windows.Controls;
using ConceptMario.Assets.Builder.Objects;
using ConceptMario.Assets.Characters;
using Objects.Characters.PlayerAssets;
using System.Collections.Generic;

namespace ConceptMario.Assets
{
    public class Map
    {
        //private bool[] Updates = new bool[] { false };
        private Canvas Can;
        //MAP GRID
        private MapGrid Grid;
        //MAP MOVING PARSTS
        private List<BulletData> Bullets = new List<BulletData>();
        private List<Enemy> Enemies = new List<Enemy>();
        //other
        private int Size = MetaData.Size;
        private TextBlock text_hp;
        private TextBlock text_coin;
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
            text_hp = new TextBlock();
            Can.Children.Add(text_hp);
            Canvas.SetTop(text_hp, 0);
            Canvas.SetLeft(text_hp, MetaData.WidthPx + 10);
            text_hp.Text = "Coin: " + player1.HitPoints.ToString();
            text_coin = new TextBlock();
            Can.Children.Add(text_coin);
            Canvas.SetTop(text_coin, 25);
            Canvas.SetLeft(text_coin, MetaData.WidthPx + 10);
            text_coin.Text = "Coin: " + player1.HitPoints.ToString();
        }
        public Canvas Get()
        {
            return Can;
        }
        public void UpdatePlayer(Player Player)
        {
            PlayerMovements(Player);
            Player.Update();
            UpdateBullets(Player);
            CatchDiamond(Player);
            CatchEnemy(Player);
            UpdateEnemies();
            //return Updates;
        }
        // ---------- PRIVATE ----------
        private void UpdateEnemies()
        {
            for (int i = 0; i < Enemies.Count; i++)
            {
                Grid.Remove(Enemies[i].GetXGrid(), Enemies[i].GetYGrid());
                Wall Block = Grid.GetBlock(Enemies[i].GetXGrid() + Enemies[i].Direction, Enemies[i].GetYGrid()) as Wall;
                Enemies[i].Move();
                Grid.SetBlock(Enemies[i].GetXGrid(), Enemies[i].GetYGrid(), Enemies[i]);
                if (Block != null)
                {
                    Enemies[i].Direction *= -1;
                }
                Canvas.SetBottom(Enemies[i].Get(), Enemies[i].GetY());
                Canvas.SetLeft(Enemies[i].Get(), Enemies[i].GetX());
            }
        }
        private void UpdateBullets(Player Player)
        {
            Bullets = Player.GetBullet(); // todo: rerender the whole screen to remove non existant bullets
            for (int i = 0; i < Bullets.Count; i++)
            {
                if (Bullets[i].Bullet == null)
                    Bullets[i].Bullet = ShapeFactory.Factory.GetShape("bullet").Get();

                if (!Can.Children.Contains(Bullets[i].Bullet))
                    Can.Children.Add(Bullets[i].Bullet);
                Canvas.SetBottom(Bullets[i].Bullet, Bullets[i].Y);
                Canvas.SetLeft(Bullets[i].Bullet, Bullets[i].X);
                Bullets[i].X += Bullets[i].BulletSpeed * Bullets[i].Direction;
                Wall block = Grid.GetBlock((Bullets[i].X - Bullets[i].Direction * Size) / Size, Bullets[i].Y / Size) as Wall;
                Enemy EnemyBlock = Grid.GetBlock((Bullets[i].X - Bullets[i].Direction * Size) / Size, Bullets[i].Y / Size) as Enemy;
                if (block != null)
                {
                    Can.Children.Remove(Bullets[i].Bullet);
                    Player.RemoveBullet(i);
                    Box box = block as Box;
                    if (box != null)
                    {
                        Can.Children.Remove(box.Get());
                        Grid.Remove(box.GetXGrid(), box.GetYGrid());
                    }
                }
                if (EnemyBlock != null)
                {
                    Can.Children.Remove(Bullets[i].Bullet);
                    Player.RemoveBullet(i);
                    bool remove = EnemyBlock.Damage(Player.GunDamage);
                    if (remove)
                    {
                        Can.Children.Remove(EnemyBlock.Get());
                        Grid.Remove(EnemyBlock.GetXGrid(), EnemyBlock.GetYGrid());
                        if (Enemies.Contains(EnemyBlock))
                        {
                            Enemies.Remove(EnemyBlock);
                        }
                    }
                }
            }
        }
        private void PlayerMovements(Player Player)
        {
            //4 nes, UP, RIGHT,DOWN, LEFT
            Wall[] Blocks = Grid.FindNearByPlayer(Player);
            //DOWN
            if (Blocks[2] != null)
            {
                if (Blocks[2].CheckDown(Player.GetY()))
                { Player.CanJump = true; }
                else { Player.CanJump = false; }
            }
            else { Player.CanJump = false; }
            //RIGHT
            if (Blocks[1] != null)
            {
                if (Blocks[1].CheckRight(Player.GetX()))
                { Player.CanRight = false; }
                else { Player.CanRight = true; }
            }
            else { Player.CanRight = true; }
            //LEFT
            if (Blocks[3] != null)
            {
                if (Blocks[3].CheckLeft(Player.GetX()))
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
                Player.Coin += diamond.Coin;
                //int index = Can.Children.IndexOf(diamond.Get());
                Can.Children.RemoveAt(Can.Children.IndexOf(diamond.Get()));
                Grid.Remove(Player.GetCenterX() / Size, Player.GetCenterY() / Size);
                //return true;
                 text_coin.Text = "Coin: " + Player.Coin.ToString();
            }
            //return false;
        }
        int Count = 0;
        private void CatchEnemy(Player Player)
        {
            Enemy enemy = Grid.GetBlock(Player.GetCenterX() / Size, Player.GetCenterY() / Size) as Enemy;
            if (enemy != null && Count >= 60)
            {
                Player.HitPoints -= 15;
                if(Player.HitPoints <= 0)
                {
                    text_hp.Text = "HP: " + 0;
                    Player.isDead = true;
                    Can.Children.Remove(Player.Get());
                    Player.Set();
                    Can.Children.Add(Player.Get());
                    Canvas.SetBottom(Player.Get(), Player.GetY());
                    Canvas.SetLeft(Player.Get(), Player.GetX());
                }
                else { text_hp.Text = "HP: " + Player.HitPoints.ToString(); }
                Count = 0;
            }
            else
            {
                Count += 1;
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
                        if (block is Enemy)
                        {
                            Enemies.Add(block as Enemy);
                        }
                        Can.Children.Add(block.Get());
                        Canvas.SetBottom(block.Get(), block.GetY());
                        Canvas.SetLeft(block.Get(), block.GetX());
                    }
                }
            }
        }
    }
}
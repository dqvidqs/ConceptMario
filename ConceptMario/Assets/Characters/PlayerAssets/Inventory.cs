using System.Collections.Generic;
using System.Windows.Controls;
namespace ConceptMario.Assets.Characters.PlayerAssets
{
    public class Inventory
    {
        private List<Item> Items = new List<Item>();
        private List<Bullet> Bullets = new List<Bullet>();
        private int Index = 0;
        public void AddItem(Item Item)
        {
            Items.Add(Item);
        }
        public int Count { get { return Items.Count; } }
        public void Remove(int Index)
        {
            if (Items.Count > 0 && Index < Items.Count)
            {
                Items.RemoveAt(Index);
                if (Index == Items.Count)
                    this.Index -=1;
            }
        }
        public int CurrectItem { get { return Index; } }
        public void Next()
        {
            Index += 1;
            if (Index == Items.Count)
                Index = 0;
        }
        public void Previous()
        {
            Index -= 1;
            if (Index < 0)
                Index = Items.Count - 1;
        }
        public void Shoot(int X, int Y, int Direction)
        {
            Bullet bullet = Items[Index].Shoot(X, Y, Direction);
            if (bullet != null)
            {
                Bullets.Add(bullet);
            }
        }
        public void Reload()
        {
            Items[Index].Relaod();
        }
        public void Update()
        {
            Items[Index].Update();
        }
        public List<Bullet> GetBullets()
        {
            return Bullets;
        }
        public void Remove(Bullet bullet)
        {
            if (Bullets.Contains(bullet))
            {
                Bullets.Remove(bullet);
            }
        }
    }
}

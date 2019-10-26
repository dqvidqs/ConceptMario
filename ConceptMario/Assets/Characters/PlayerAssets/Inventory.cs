using System.Collections.Generic;
using System.Windows.Controls;
namespace ConceptMario.Assets.Characters.PlayerAssets
{
    class Inventory
    {
        private List<Item> Items = new List<Item>();
        private int Index = 0;
        public void AddItem(Item Item)
        {
            Items.Add(Item);
        }
        public void Remove(int Index)
        {
            if (Items.Count > 0 && Index < Items.Count)
            {
                Items.RemoveAt(Index);
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
            if (Index == 0)
                Index = Items.Count - 1;
        }
        public void Shoot(int X, int Y, int Direction)
        {
            Items[Index].Shoot(X, Y, Direction);
        }
        public void Reload()
        {
            Items[Index].Relaod();
        }
        public void Update(Canvas canvas)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Items[i].Update(canvas);
            }
        }
    }
}

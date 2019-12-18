using Objects.Enums;
using System.Collections.Generic;

namespace Objects.Characters.PlayerAssets
{
    public class Inventory
    {
        private List<IGun> Guns = new List<IGun>();
        private List<BulletData> BulletData = new List<BulletData>();
        private int Index = 0;
        public void AddItem(IGun Gun)
        {
            Guns.Add(Gun);
        }
        public int Count { get { return Guns.Count; } }
        public void Remove(int Index)
        {
            if (Guns.Count > 0 && Index < Guns.Count)
            {
                Guns.RemoveAt(Index);
                if (Index == Guns.Count)
                    this.Index -=1;
            }
        }
        public int CurrectItem { get { return Index; } }
        public void Next()
        {
            Index += 1;
            if (Index == Guns.Count)
                Index = 0;
        }
        public void Previous()
        {
            Index -= 1;
            if (Index < 0)
                Index = Guns.Count - 1;
        }
        public int Shoot(int x, int y, Directions direction)
        {
            var bullet = Guns[Index].Shoot(x, y, direction);
            if (bullet != null)
            {
                BulletData.Add(bullet);
            }
            return Guns[Index].Damage();
        }

        public void RemoveBullet(int i)
        {
            BulletData.RemoveAt(i);
        }

        public IGun GetItem()
        {
            return Guns[CurrectItem];
        }
        /*public void Reload()
        {
            Guns[Index].Relaod();
        }
        public void Update()
        {
            Guns[Index].Update();
        }*/
        public List<BulletData> GetBulletsData()
        {
            return BulletData;
        }


        public void Remove(BulletData bullet)
        {
            if (BulletData.Contains(bullet))
            {
                BulletData.Remove(bullet);
            }
        }
    }
}

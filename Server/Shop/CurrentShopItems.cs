using Objects.Characters.PlayerAssets;
using Objects.Decorator;
using Server.Factory;
using System;
using System.Collections.Generic;


namespace Server.Shop
{
    public class CurrentShopItems
    {
        bool hasChangedThisHour;
        public List<Gun> Guns { get; set; }
        private static CurrentShopItems _shop;
        private Random random;

        //public static CurrentShopItems GetShop()
        //{
        //    if(_shop == null)
        //    {
        //        _shop = new CurrentShopItems();
        //    }

        //    return _shop;
        //}
        private CurrentShopItems()
        {
            Guns = new List<Gun>();
            random = new Random();
            for (int i = 0; i < 3; i++)
            {
                var value = random.Next(100);
                var pistol = GunFactory.ReturnItem();                 

                while (value < 50)
                {
                    if(value < 25)
                    {
                        pistol = new DarkItem(pistol);
                    } else
                    {
                        pistol = new EndlessItem(pistol);
                    }

                    value = random.Next(100);
                }

                Guns.Add(pistol);
            }
        }
    }
}
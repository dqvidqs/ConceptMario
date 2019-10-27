using System;
using ConceptMario.Assets.Characters;
using System.Windows.Shapes;
using System.Collections.Generic;
using ConceptMario.Assets.Characters.PlayerAssets;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConceptMario.Test
{
    [TestClass]
    public class UnitTestPlayerAssets
    {
        [TestMethod]
        public void InventoryAddItem()
        {
            int expected = 2;
            Inventory inv = new Inventory();
            inv.AddItem(new Pistol(0,0));
            inv.AddItem(new Pistol(0, 0));
            Assert.AreEqual(expected, inv.Count);
        }
        [TestMethod]
        public void InventoryCurrectItemNextItem()
        {
            int expected = 1;
            Inventory inv = new Inventory();
            inv.AddItem(new Pistol(0, 0));
            inv.AddItem(new Pistol(0, 0));
            inv.AddItem(new Pistol(0, 0));
            inv.Next();
            inv.Next();
            inv.Next();
            inv.Next();
            Assert.AreEqual(expected, inv.CurrectItem);
        }
        [TestMethod]
        public void InventoryCurrectItemPreviuosItem()
        {
            int expected = 2;
            Inventory inv = new Inventory();
            inv.AddItem(new Pistol(0, 0));
            inv.AddItem(new Pistol(0, 0));
            inv.AddItem(new Pistol(0, 0));
            inv.Previous();
            inv.Previous();
            inv.Previous();
            inv.Previous();
            Assert.AreEqual(expected, inv.CurrectItem);
        }
        [TestMethod]
        public void InventoryCurrectItemPreviuosItemRemove()
        {
            int expected = 1;
            Inventory inv = new Inventory();
            inv.AddItem(new Pistol(0, 0));
            inv.AddItem(new Pistol(0, 0));
            inv.AddItem(new Pistol(0, 0));
            inv.Previous();
            inv.Previous();
            inv.Previous();
            inv.Previous();
            inv.Remove(inv.CurrectItem);
            Assert.AreEqual(expected, inv.CurrectItem);
        }
        [TestMethod]
        public void InventoryGetBulletsShoot()
        {
            int expected = 1;
            Inventory inv = new Inventory();
            inv.AddItem(new Pistol(1, 1));
            inv.Shoot(0, 0, 1);
            List<Bullet> bull = inv.GetBullets();
            Assert.AreEqual(expected, bull.Count);
        }
    }
}

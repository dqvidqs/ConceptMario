using System;
using ConceptMario.Assets.Characters;
using System.Windows.Shapes;
using System.Collections.Generic;
using ConceptMario.Assets.Characters.PlayerAssets;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConceptMario.Test
{
    [TestClass]
    public class UnitTestCharacter
    {
        [TestMethod]
        public void PlayerGet()
        {
            Player player = new Player(0, 0);
            Assert.AreNotEqual(null, player.Get());
        }
        [TestMethod]
        public void PlayerGetCenterX()
        {
            int expected = 62;
            Player player = new Player(50, 50);
            Assert.AreEqual(expected,player.GetCenterX());
        }
        [TestMethod]
        public void PlayerGetCenterY()
        {
            int expected = 62;
            Player player = new Player(50, 50);
            Assert.AreEqual(expected, player.GetCenterY());
        }
        [TestMethod]
        public void PlayerGetX()
        {
            int expected = 50;
            Player player = new Player(50, 50);
            Assert.AreEqual(expected, player.GetX());
        }
        [TestMethod]
        public void PlayerGetY()
        {
            int expected = 50;
            Player player = new Player(50, 50);
            Assert.AreEqual(expected, player.GetY());
        }
        [TestMethod]
        public void PlayerMoveY()
        {
            int expected = 50;
            Player player = new Player(50, 50);
            player.Move();
            Assert.AreNotEqual(expected, player.GetY());
        }
        [TestMethod]
        public void PlayerMoveX()
        {
            int expected = 50;
            Player player = new Player(50, 50);
            player.Left = true;
            player.Move();
            Assert.AreNotEqual(expected, player.GetX());
        }
        [TestMethod]
        public void PlayerShootingGetBullets()
        {
            int expected = 1; 
            Player player = new Player(50, 50);
            player.IsShooting = true;
            player.Move();
            List<Bullet> bull = player.GetBullets();
            Assert.AreEqual(expected, bull.Count);
        }
        [TestMethod]
        public void PlayerUpdateGetBullets()
        {
            int expected = 7;
            Player player = new Player(50, 50);
            player.IsShooting = true;
            for(int i =0; i < 999; i++)
            {
                player.Update();
                player.Move();
            }
            List<Bullet> bull = player.GetBullets();
            Assert.AreEqual(expected, bull.Count);
        }
        [TestMethod]
        public void PlayerReloadGetBullets()
        {
            int expected = 14;
            Player player = new Player(50, 50);
            player.IsShooting = true;
            for (int i = 0; i < 999; i++)
            {
                player.Update();
                player.Move();
            }
            player.Reload();
            for (int i = 0; i < 999; i++)
            {
                player.Update();
                player.Move();
            }
            List<Bullet> bull = player.GetBullets();
            Assert.AreEqual(expected, bull.Count);
        }
    }
}

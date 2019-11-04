﻿using System;
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
            player.Update(); ;
            Assert.AreNotEqual(expected, player.GetY());
        }
        [TestMethod]
        public void PlayerMoveX()
        {
            int expected = 50;
            Player player = new Player(50, 50);
            player.Left = true;
            player.Update();
            Assert.AreNotEqual(expected, player.GetX());
        }
        [TestMethod]
        public void PlayerUpdateIntInt()
        {
            int expected = 50;
            Player player = new Player(50, 50);
            player.Update(0, 0);
            Assert.AreNotEqual(expected, player.GetX());
        }
        [TestMethod]
        public void PlayerMoveY2()
        {
            int expected = 50;
            Player player = new Player(50, 50);
            player.CanJump = true;
            player.IsJump = true;
            for (int i = 0; i < 10; i++)
            {
                player.Update();
            }
            Assert.AreNotEqual(expected, player.GetY());
        }
        [TestMethod]
        public void PlayerMoveX2()
        {
            int expected = 50;
            Player player = new Player(50, 50);
            player.Right = true;
            player.Update();
            Assert.AreNotEqual(expected, player.GetX());
        }
        [TestMethod]
        public void PlayerShootingGetBullets()
        {
            int expected = 1; 
            Player player = new Player(50, 50);
            player.IsShooting = true;
            player.Update();
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
            }
            List<Bullet> bull = player.GetBullets();
            Assert.AreEqual(expected, bull.Count);
        }
        [TestMethod]
        public void PlayerReloadGetBullets()
        {
            int expected = 14;
            Player player = new Player(50, 50);
            player.IsShooting = true;//parodo kad saudo
            for (int i = 0; i < 999; i++)//iteracijos arba kadrai
            {
                player.Update();
                player.Update(); ;
            }
            player.Reload();//uztaiso
            for (int i = 0; i < 999; i++)
            {
                player.Update();
                player.Update(); 
            }
            List<Bullet> bull = player.GetBullets();
            Assert.AreEqual(expected, bull.Count);
        }
    }
}

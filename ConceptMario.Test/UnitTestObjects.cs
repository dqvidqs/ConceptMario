using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConceptMario.Assets.MapBuilder.Objects;
using System.Windows.Shapes;
namespace ConceptMario.Test
{
    [TestClass]
    public class UnitTestObjects
    {
        //----------------------
        //Test Box class
        //----------------------
        [TestMethod]
        public void BoxGet()
        {
            Polygon expected = new Polygon();
            Box block = new Box(0, 0, expected);
            Assert.AreEqual(expected, block.Get());
        }
        [TestMethod]
        public void BoxGetX()
        {
            int expected = 125;
            Box block = new Box(125, 0, null);
            Assert.AreEqual(expected, block.GetX());
        }
        [TestMethod]
        public void BoxGetY()
        {
            int expected = 150;
            Box block = new Box(0, 150, null);
            Assert.AreEqual(expected, block.GetY());
        }
        [TestMethod]
        public void BoxGetXGrid()
        {
            int expected = 6;
            Box block = new Box(150, 0, null);
            Assert.AreEqual(expected, block.GetXGrid());
        }
        [TestMethod]
        public void BoxGetYGrid()
        {
            int expected = 7;
            Box block = new Box(0, 175, null);
            Assert.AreEqual(expected, block.GetYGrid());
        }
        [TestMethod]
        public void BoxCheckCenter()
        {
            bool expected = true;
            Box block = new Box(0, 175, null);
            Assert.AreEqual(expected, block.CheckCenter(12, 190));
        }
        [TestMethod]
        public void BoxCheckCenterFalse()
        {
            bool expected = false;
            Box block = new Box(0, 175, null);
            Assert.AreEqual(expected, block.CheckCenter(12, 201));
        }
        [TestMethod]
        public void BoxCheckDown()
        {
            bool expected = true;
            Box block = new Box(0, 175, null);
            Assert.AreEqual(expected, block.CheckDown(12, 175));
        }
        [TestMethod]
        public void BoxCheckLeft()
        {
            bool expected = true;
            Box block = new Box(175, 175, null);
            Assert.AreEqual(expected, block.CheckLeft(175, 0));
        }
        [TestMethod]
        public void BoxCheckRight()
        {
            bool expected = true;
            Box block = new Box(175, 175, null);
            Assert.AreEqual(expected, block.CheckRight(150, 175));
        }
        [TestMethod]
        public void BoxCheckUp()
        {
            bool expected = true;
            Box block = new Box(175, 175, null);
            Assert.AreEqual(expected, block.CheckUp(175, 150));
        }

        //----------------------
        //Test Diamond class
        //----------------------
        [TestMethod]
        public void DiamondGet()
        {
            Polygon expected = new Polygon();
            Diamond block = new Diamond(0, 0, expected);
            Assert.AreEqual(expected, block.Get());
        }
        [TestMethod]
        public void DiamondGetX()
        {
            int expected = 125;
            Diamond block = new Diamond(125, 0, null);
            Assert.AreEqual(expected, block.GetX());
        }
        [TestMethod]
        public void DiamondGetY()
        {
            int expected = 150;
            Diamond block = new Diamond(0, 150, null);
            Assert.AreEqual(expected, block.GetY());
        }
        [TestMethod]
        public void DiamondGetXGrid()
        {
            int expected = 6;
            Diamond block = new Diamond(150, 0, null);
            Assert.AreEqual(expected, block.GetXGrid());
        }
        [TestMethod]
        public void DiamondGetYGrid()
        {
            int expected = 7;
            Diamond block = new Diamond(0, 175, null);
            Assert.AreEqual(expected, block.GetYGrid());
        }
        [TestMethod]
        public void DiamondCheckCenter()
        {
            bool expected = true;
            Diamond block = new Diamond(0, 175, null);
            Assert.AreEqual(expected, block.CheckCenter(24, 176));
        }
        [TestMethod]
        public void DiamondCheckCenterFalse()
        {
            bool expected = false;
            Diamond block = new Diamond(0, 175, null);
            Assert.AreEqual(expected, block.CheckCenter(24, 201));
        }
        //----------------------
        //Test Door class
        //----------------------
        [TestMethod]
        public void DoorGet()
        {
            Polygon expected = new Polygon();
            Door block = new Door(0, 0, expected);
            Assert.AreEqual(expected, block.Get());
        }
        [TestMethod]
        public void DoorGetX()
        {
            int expected = 125;
            Door block = new Door(125, 0, null);
            Assert.AreEqual(expected, block.GetX());
        }
        [TestMethod]
        public void DoorGetY()
        {
            int expected = 150;
            Door block = new Door(0, 150, null);
            Assert.AreEqual(expected, block.GetY());
        }
        [TestMethod]
        public void DoorGetXGrid()
        {
            int expected = 6;
            Door block = new Door(150, 0, null);
            Assert.AreEqual(expected, block.GetXGrid());
        }
        [TestMethod]
        public void DoorGetYGrid()
        {
            int expected = 7;
            Door block = new Door(0, 175, null);
            Assert.AreEqual(expected, block.GetYGrid());
        }
        //----------------------
        //Test Enemy class
        //----------------------
        [TestMethod]
        public void EnemyGet()
        {
            Polygon expected = new Polygon();
            Enemy block = new Enemy(0, 0, expected);
            Assert.AreEqual(expected, block.Get());
        }
        [TestMethod]
        public void EnemyGetX()
        {
            int expected = 125;
            Enemy block = new Enemy(125, 0, null);
            Assert.AreEqual(expected, block.GetX());
        }
        [TestMethod]
        public void EnemyGetY()
        {
            int expected = 150;
            Enemy block = new Enemy(0, 150, null);
            Assert.AreEqual(expected, block.GetY());
        }
        [TestMethod]
        public void EnemyGetXGrid()
        {
            int expected = 6;
            Enemy block = new Enemy(150, 0, null);
            Assert.AreEqual(expected, block.GetXGrid());
        }
        [TestMethod]
        public void EnemyGetYGrid()
        {
            int expected = 7;
            Enemy block = new Enemy(0, 175, null);
            Assert.AreEqual(expected, block.GetYGrid());
        }
        [TestMethod]
        public void EnemyCheckCenter()
        {
            bool expected = true;
            Enemy block = new Enemy(0, 175, null);
            Assert.AreEqual(expected, block.CheckCenter(24, 176));
        }
        [TestMethod]
        public void EnemyCheckCenterFalse()
        {
            bool expected = false;
            Enemy block = new Enemy(0, 175, null);
            Assert.AreEqual(expected, block.CheckCenter(24, 201));
        }
        [TestMethod]
        public void EnemyDirectionGet()
        {
            int expected = 1;
            Enemy block = new Enemy(0, 0, null);
            Assert.AreEqual(expected, block.Direction);
        }
        [TestMethod]
        public void EnemyDirectionSet()
        {
            int expected = 99;
            Enemy block = new Enemy(0, 0, null);
            block.Direction = 99;
            Assert.AreEqual(expected, block.Direction);
        }
        [TestMethod]
        public void EnemyMove()
        {
            int expected = 1;
            Enemy block = new Enemy(0, 0, null);
            block.Move();
            Assert.AreEqual(expected, block.GetX());
        }
        //----------------------
        //Test Wall class
        //----------------------
        [TestMethod]
        public void WallGet()
        {
            Polygon expected = new Polygon();
            Wall block = new Wall(0, 0, expected);
            Assert.AreEqual(expected, block.Get());
        }
        [TestMethod]
        public void WallGetX()
        {
            int expected = 125;
            Wall block = new Wall(125, 0, null);
            Assert.AreEqual(expected, block.GetX());
        }
        [TestMethod]
        public void WallGetY()
        {
            int expected = 150;
            Wall block = new Wall(0, 150, null);
            Assert.AreEqual(expected, block.GetY());
        }
        [TestMethod]
        public void WallGetXGrid()
        {
            int expected = 6;
            Wall block = new Wall(150, 0, null);
            Assert.AreEqual(expected, block.GetXGrid());
        }
        [TestMethod]
        public void WallGetYGrid()
        {
            int expected = 7;
            Wall block = new Wall(0, 175, null);
            Assert.AreEqual(expected, block.GetYGrid());
        }
        [TestMethod]
        public void WallCheckDown()
        {
            bool expected = true;
            Wall block = new Wall(0, 175, null);
            Assert.AreEqual(expected, block.CheckDown(12, 175));
        }
        [TestMethod]
        public void WallCheckLeft()
        {
            bool expected = true;
            Wall block = new Wall(175, 175, null);
            Assert.AreEqual(expected, block.CheckLeft(175, 0));
        }
        [TestMethod]
        public void WallCheckLeftFalse()
        {
            bool expected = false;
            Wall block = new Wall(175, 175, null);
            Assert.AreEqual(expected, block.CheckLeft(201, 0));
        }
        [TestMethod]

        public void WallCheckRight()
        {
            bool expected = true;
            Wall block = new Wall(175, 175, null);
            Assert.AreEqual(expected, block.CheckRight(150, 175));
        }
        [TestMethod]

        public void WallCheckRightFalse()
        {
            bool expected = false;
            Wall block = new Wall(175, 175, null);
            Assert.AreEqual(expected, block.CheckRight(175, 175));
        }
        [TestMethod]
        public void WallCheckUp()
        {
            bool expected = true;
            Wall block = new Wall(175, 175, null);
            Assert.AreEqual(expected, block.CheckUp(175, 150));
        }
    }
}

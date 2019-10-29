using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConceptMario.Assets.MapBuilder;
using ConceptMario.Assets.MapBuilder.Objects;
//using System.Window

namespace ConceptMario.Test
{
    [TestClass]
    public class UnitTestMapObjects
    {
        //-------------------------
        // Class MapObjects test
        //-------------------------
        [TestMethod]
        public void AddBlock()
        {
            Block example = new Diamond(0, 0, null);
            MapObjects Objects = new MapObjects();
            Objects.AddBock(example);
            Assert.AreEqual(example, Objects.GetBlocks()[0]);
        }
        [TestMethod]
        public void GetFirstBlock()
        {
            Block example = new Diamond(0, 0, null);
            List<Block> list = new List<Block>();
            list.Add(example);
            MapObjects Objects = new MapObjects();
            Objects.AddBock(example);
            Assert.AreEqual(list[0], Objects.GetBlocks()[0]);
        }
        [TestMethod]
        public void BlockCount()
        {
            Block example0 = new Diamond(0, 0, null);
            Block example1 = new Diamond(0, 0, null);
            MapObjects Objects = new MapObjects();
            Objects.AddBock(example0);
            Objects.AddBock(example1);
            Assert.AreEqual(2, Objects.Count);
        }
        //-------------------------
        // Class MapBuilder test
        //-------------------------
        [TestMethod]
        public void BuilderWall()
        {
            string example = "00100";
            bool expected = true;
            MapBuilder Builder = new MapBuilder(example);
            Builder.BuildWalls();
            List<Block> Blocks = Builder.GetBlocks();
            Assert.AreEqual(expected, Blocks[0] is Wall);
        }
        [TestMethod]
        public void BuilderDiamond()
        {
            string example = "00200";
            bool expected = true;
            MapBuilder Builder = new MapBuilder(example);
            Builder.BuildDiamonds();
            List<Block> Blocks = Builder.GetBlocks();
            Assert.AreEqual(expected, Blocks[0] is Diamond);
        }
        [TestMethod]
        public void BuilderDoor()
        {
            string example = "00300";
            bool expected = true;
            MapBuilder Builder = new MapBuilder(example);
            Builder.BuildDoors();
            List<Block> Blocks = Builder.GetBlocks();
            Assert.AreEqual(expected, Blocks[0] is Door);
        }
        [TestMethod]
        public void BuilderBox()
        {
            string example = "00400";
            bool expected = true;
            MapBuilder Builder = new MapBuilder(example);
            Builder.BuildBoxes();
            List<Block> Blocks = Builder.GetBlocks();
            Assert.AreEqual(expected, Blocks[0] is Box);
        }
        [TestMethod]
        public void BuilderEnemy()
        {
            string example = "00500";
            bool expected = true;
            MapBuilder Builder = new MapBuilder(example);
            Builder.GetBlocks();
            List<Block> Blocks = Builder.GetBlocks();
            Assert.AreEqual(expected, Blocks[0] is Enemy);
        }
        [TestMethod]
        public void BuilderGetBlocks()
        {
            string example = "0000000012345123450000000";
            int expected = 10;
            MapBuilder Builder = new MapBuilder(example);
            Builder.BuildEnemies();
            Builder.BuildBoxes();
            Builder.BuildDiamonds();
            Builder.BuildDoors();
            Builder.BuildWalls();
            List<Block> Blocks = Builder.GetBlocks();
            Assert.AreEqual(expected, Blocks.Count);
        }
    }
}

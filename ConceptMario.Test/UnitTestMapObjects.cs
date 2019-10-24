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
        [TestMethod]
        public void AddBlock()
        {
            Block example = new Diamond();
            MapObjects Objects = new MapObjects();
            Objects.AddBock(example);
            Assert.AreEqual(example, Objects.GetBlocks()[0]);
        }
        [TestMethod]
        public void GetFirstBlock()
        {
            Block example = new Diamond();
            List<Block> list = new List<Block>();
            list.Add(example);
            MapObjects Objects = new MapObjects();
            Objects.AddBock(example);
            Assert.AreSame(list[0], Objects.GetBlocks()[0]);
        }
        [TestMethod]
        public void BlockCount()
        {
            Block example0 = new Diamond();
            Block example1 = new Diamond();
            MapObjects Objects = new MapObjects();
            Objects.AddBock(example0);
            Objects.AddBock(example1);
            Assert.AreEqual(2, Objects.Count);
        }
    }
}

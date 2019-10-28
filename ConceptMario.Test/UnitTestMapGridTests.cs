using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConceptMario.Assets;
using ConceptMario.Assets.Characters;
using ConceptMario.Assets.MapBuilder.Objects;

namespace ConceptMario.Test
{
    [TestClass()]
    public class UnitTestMapGridTests
    {
        [TestMethod()]
        public void MapGridTest()
        {
            MapGrid mapGrid = new MapGrid(0);
            Assert.AreNotEqual(null, mapGrid);
        }

        [TestMethod()]
        public void GetBlockTest()
        {
            MapGrid mapGrid = new MapGrid(0);
            var block = mapGrid.GetBlock(0, 0);
            Assert.AreNotEqual(null, block);
        }

        [TestMethod()]
        public void SetBlockTest()
        {
            MapGrid mapGrid = new MapGrid(0);
            mapGrid.SetBlock(5, 5, new object());
            Assert.AreNotEqual(null, mapGrid.GetBlock(5, 5));
        }

        [TestMethod()]
        public void FindNearByPlayerTest()
        {
            MapGrid mapGrid = new MapGrid(0);
            Player player = new Player(25, 25);
            var blocks = mapGrid.FindNearByPlayer(player);
            Assert.AreNotEqual(null, blocks[2]);
        }

        [TestMethod()]
        public void RemoveTest()
        {
            MapGrid mapGrid = new MapGrid(0);
            mapGrid.Remove(0, 0);
            var block = mapGrid.GetBlock(0, 0);
            Assert.AreEqual(null, block);
        }
    }
}
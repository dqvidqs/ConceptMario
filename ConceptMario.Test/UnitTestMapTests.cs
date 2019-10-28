using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConceptMario.Assets;
using ConceptMario.Assets.Characters;
using System.Windows.Controls;

namespace ConceptMario.Test
{
    [TestClass()]
    public class UnitTestMapTests
    {
        [TestMethod()]
        public void MapTest()
        {
            Player player1 = new Player(0,0);
            Player player2 = new Player(0,0);
            Map map = new Map(player1,player2,0);
            Assert.AreNotEqual(null, map);
        }

        [TestMethod()]
        public void GetTest()
        {
            Player player1 = new Player(0, 0);
            Player player2 = new Player(0, 0);
            Map map = new Map(player1, player2, 0);
            Assert.AreNotEqual(null, map.Get());
        }

        [TestMethod()]
        public void UpdatePlayerTest()
        {
            Player player1 = new Player(100, 100);
            int Y = player1.GetCenterY();
            Player player2 = new Player(100, 100);
            Map map = new Map(player1, player2, 0);
            player1.Move();
            map.UpdatePlayer(player1);
            Assert.AreNotEqual(Y, player1.GetCenterY());
        }
    }
}
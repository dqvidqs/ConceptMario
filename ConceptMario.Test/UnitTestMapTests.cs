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
            map.UpdatePlayer(player1);
            //player1.Move();
            Assert.AreNotEqual(Y, player1.GetCenterY());
        }
        [TestMethod()]
        public void UpdatePlayerCatchDiamondTest()
        {
            Player player1 = new Player(125, 25);
            int Y = player1.GetCenterY();
            Player player2 = new Player(100, 100);
            Map map = new Map(player1, player2, 0);            
            map.UpdatePlayer(player2);
           // player2.Move();           
            map.UpdatePlayer(player1);
            //player1.Move();
            Assert.AreNotEqual(Y, player2.GetCenterY());
        }
        [TestMethod()]
        public void UpdatePlayersUpdateBulletsdTest()
        {
            Player player1 = new Player(125, 25);
            int Y = player1.GetCenterY();
            Player player2 = new Player(100, 100);
            Map map = new Map(player1, player2, 0);
            player2.IsShooting = true;
            for (int i = 0; i < 20; i++)
            {
                map.UpdatePlayer(player2);
                //player2.Move();
                map.UpdatePlayer(player1);
                //player1.Move();
            }
            Assert.AreEqual(Y, player2.GetCenterY());
        }
    }
}
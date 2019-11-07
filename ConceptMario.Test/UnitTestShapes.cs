using ConceptMario.Assets.ShapeFactory.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConceptMario.Assets.ShapeFactory.Color;

namespace ConceptMario.Test
{
    [TestClass]
    public class UnitTestShapes
    {
        [TestMethod]
        public void BoxShapeCreate()
        {
            BlockShape Item = new BlockShape(new Blue());
            Assert.AreNotEqual(null, Item);
        }
        [TestMethod]
        public void BoxShapeGet()
        {
            BlockShape Item = new BlockShape(new Blue());
            Assert.AreNotEqual(null, Item.Get());
        }
        [TestMethod]
        public void BulletShapeCreate()
        {
            BulletShape Item = new BulletShape(new Blue());
            Assert.AreNotEqual(null, Item);
        }
        [TestMethod]
        public void BulletShapeGet()
        {
            BulletShape Item = new BulletShape(new Blue());
            Assert.AreNotEqual(null, Item.Get());
        }
        [TestMethod]
        public void DiamondShapeCreate()
        {
            DiamondShape Item = new DiamondShape(new Blue());
            Assert.AreNotEqual(null, Item);
        }
        [TestMethod]
        public void DiamondShapeGet()
        {
            DiamondShape Item = new DiamondShape(new Blue());
            Assert.AreNotEqual(null, Item.Get());
        }
        [TestMethod]
        public void DoorShapeCreate()
        {
            DoorShape Item = new DoorShape(new Blue());
            Assert.AreNotEqual(null, Item);
        }
        [TestMethod]
        public void DoorShapeGet()
        {
            DiamondShape Item = new DiamondShape(new Blue();
            Assert.AreNotEqual(null, Item.Get());
        }
        [TestMethod]
        public void EnemyShapeCreate()
        {
            EnemyShape Item = new EnemyShape(new Blue());
            Assert.AreNotEqual(null, Item);
        }
        [TestMethod]
        public void EnemyShapeGet()
        {
            EnemyShape Item = new EnemyShape(new Blue());
            Assert.AreNotEqual(null, Item.Get());
        }
        [TestMethod]
        public void PlayerShapeCreate()
        {
            PlayerShape Item = new PlayerShape(new Blue());
            Assert.AreNotEqual(null, Item);
        }
        [TestMethod]
        public void PlayerShapeGet()
        {
            PlayerShape Item = new PlayerShape(new Blue());
            Assert.AreNotEqual(null, Item.Get());
        }
        [TestMethod]
        public void WallShapeCreate()
        {
            WallShape Item = new WallShape(new Blue());
            Assert.AreNotEqual(null, Item);
        }
        [TestMethod]
        public void WallShapeGet()
        {
            WallShape Item = new WallShape(new Blue());
            Assert.AreNotEqual(null, Item.Get());
        }
    }
}

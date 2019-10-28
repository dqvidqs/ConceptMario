using ConceptMario.Assets.ShapeFactory;
using ConceptMario.Assets.ShapeFactory.Shapes;
using ConceptMario.Assets.MapBuilder.Objects;
using System.Windows.Shapes;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConceptMario.Test
{
    [TestClass]
    public class UnitTestShapes
    {
        [TestMethod]
        public void BoxShapeCreate()
        {
            BoxShape Item = new BoxShape();
            Assert.AreNotEqual(null, Item);
        }
        [TestMethod]
        public void BoxShapeGet()
        {
            BoxShape Item = new BoxShape();
            Assert.AreNotEqual(null, Item.Get());
        }
        [TestMethod]
        public void BulletShapeCreate()
        {
            BulletShape Item = new BulletShape();
            Assert.AreNotEqual(null, Item);
        }
        [TestMethod]
        public void BulletShapeGet()
        {
            BulletShape Item = new BulletShape();
            Assert.AreNotEqual(null, Item.Get());
        }
        [TestMethod]
        public void DiamondShapeCreate()
        {
            DiamondShape Item = new DiamondShape();
            Assert.AreNotEqual(null, Item);
        }
        [TestMethod]
        public void DiamondShapeGet()
        {
            DiamondShape Item = new DiamondShape();
            Assert.AreNotEqual(null, Item.Get());
        }
        [TestMethod]
        public void DoorShapeCreate()
        {
            DoorShape Item = new DoorShape();
            Assert.AreNotEqual(null, Item);
        }
        [TestMethod]
        public void DoorShapeGet()
        {
            DiamondShape Item = new DiamondShape();
            Assert.AreNotEqual(null, Item.Get());
        }
        [TestMethod]
        public void EnemyShapeCreate()
        {
            EnemyShape Item = new EnemyShape();
            Assert.AreNotEqual(null, Item);
        }
        [TestMethod]
        public void EnemyShapeGet()
        {
            EnemyShape Item = new EnemyShape();
            Assert.AreNotEqual(null, Item.Get());
        }
        [TestMethod]
        public void PlayerShapeCreate()
        {
            PlayerShape Item = new PlayerShape();
            Assert.AreNotEqual(null, Item);
        }
        [TestMethod]
        public void PlayerShapeGet()
        {
            PlayerShape Item = new PlayerShape();
            Assert.AreNotEqual(null, Item.Get());
        }
        [TestMethod]
        public void WallShapeCreate()
        {
            WallShape Item = new WallShape();
            Assert.AreNotEqual(null, Item);
        }
        [TestMethod]
        public void WallShapeGet()
        {
            WallShape Item = new WallShape();
            Assert.AreNotEqual(null, Item.Get());
        }
    }
}

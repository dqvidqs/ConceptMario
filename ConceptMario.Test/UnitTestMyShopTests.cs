using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConceptMario.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptMario.Test
{
    [TestClass()]
    public class UnitTestMyShopTests
    {
        [TestMethod()]
        public void GetShopTest()
        {
            var shop = MyShop.GetShop();
            Assert.AreNotEqual(null, shop);
        }
    }
}
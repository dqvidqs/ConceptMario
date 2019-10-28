// <copyright file="MapTest.cs">Copyright ©  2019</copyright>
using System;
using System.Windows.Controls;
using ConceptMario.Assets;
using ConceptMario.Assets.Characters;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConceptMario.Assets.Test
{
    /// <summary>This class contains parameterized unit tests for Map</summary>
    [PexClass(typeof(Map))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class MapTest
    {
        /// <summary>Test stub for CatchDiamond(Player)</summary>
        [PexMethod]
        public bool CatchDiamondTest([PexAssumeUnderTest]Map target, Player Player)
        {
            bool result = target.CatchDiamond(Player);
            return result;
            // TODO: add assertions to method MapTest.CatchDiamondTest(Map, Player)
        }

        /// <summary>Test stub for .ctor(Player, Player, Int32)</summary>
        [PexMethod]
        public Map ConstructorTest(
            Player player1,
            Player player2,
            int MapId
        )
        {
            Map target = new Map(player1, player2, MapId);
            return target;
            // TODO: add assertions to method MapTest.ConstructorTest(Player, Player, Int32)
        }

        /// <summary>Test stub for Get()</summary>
        [PexMethod]
        public Canvas GetTest([PexAssumeUnderTest]Map target)
        {
            Canvas result = target.Get();
            return result;
            // TODO: add assertions to method MapTest.GetTest(Map)
        }

        /// <summary>Test stub for UpdatePlayer(Player)</summary>
        [PexMethod]
        public bool[] UpdatePlayerTest([PexAssumeUnderTest]Map target, Player Player)
        {
            bool[] result = target.UpdatePlayer(Player);
            return result;
            // TODO: add assertions to method MapTest.UpdatePlayerTest(Map, Player)
        }
    }
}

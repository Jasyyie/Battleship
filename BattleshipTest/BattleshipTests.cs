using Microsoft.VisualStudio.TestTools.UnitTesting;
using Battleship;
using System.Drawing;

namespace BattleshipTest
{
    [TestClass]
    public class BattleshipTests
    {
        [TestMethod]
        public void ShipParametersTest()
        {
            // Arrange
            string startingPoint = "0,0";
            string orientation = "Horizontal";
            string length = "2";
            Point ExpectedStartingPoint = new Point(0,0);
            var ExpectedOrientation = ShipOrientation.Horizontal;
            int ExpectedLength = 2;
            Point[] ExpectedPosition = new Point[] { new Point { X = 0, Y = 0 }, new Point { X = 0, Y = 1 } };
            // Act
            var ship = new Ship(startingPoint, orientation, length);
            var originalStartingPoint = ship.Startingpoint;
            var originalOrientation = ship.Orientation;
            var originalLength = ship.Length;
            var originalPosition = ship.Position;
            // Assert
            Assert.AreEqual(ExpectedStartingPoint, originalStartingPoint);
            Assert.AreEqual(ExpectedOrientation, originalOrientation);
            Assert.AreEqual(ExpectedLength, originalLength);
            CollectionAssert.AreEqual(ExpectedPosition, originalPosition);
        }
    }
}

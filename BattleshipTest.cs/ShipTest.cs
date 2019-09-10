using Xunit;
using Battleship;

namespace BattleshipTest.cs
{
    public class ShipTest
    {
        [Theory]
        [InlineData("0,0", "Horizontal", "2")]
        public void PassingTest(string startingPoint, string orientation, string length)
        {
           
            var ship = new Ship(startingPoint, orientation, length);
            //Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}


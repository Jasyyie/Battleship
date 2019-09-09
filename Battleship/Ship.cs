using System;
using System.Drawing;

namespace Battleship
{
    public class Ship
    {
        public int[,] Position { get; set; }
        public ShipOrientation Orientation { get; set; }

        public int[,] Startingpoint { get; set; }
        public string Length { get; set; }
        public Point GetPoint(int xCoordinate, int yCoordinate)
        {
            Point point1 = new Point(xCoordinate, yCoordinate);
            return point1;
        }
    }
}

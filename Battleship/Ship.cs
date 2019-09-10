using System;
using System.Drawing;

namespace Battleship
{
    public class Ship
    {
        public Point Startingpoint { get; set; }
        public ShipOrientation Orientation { get; set; }
        public Point[] Position { get; set; }
       
        public int Length { get; set; }

        public Ship(string startingpoint, string orientation, string length)
        {
           Startingpoint = GetStartingPoint(startingpoint);
           Orientation = GetOrientation(orientation);
           Length = GetLength(length);
           Position = SetPosition(Startingpoint, Orientation, Length);
        }
        
        public Point GetPoint(int xCoordinate, int yCoordinate)
        {
            Point point1 = new Point(xCoordinate, yCoordinate);
            return point1;
        }

        private Point GetStartingPoint(string startingPoint)
        {
            string[] startingPoints = startingPoint.Split(',');
            int coordinateX = int.Parse(startingPoints[0]);
            int coordinateY = int.Parse(startingPoints[1]);
            return new Point( coordinateX, coordinateY);

        }

        private ShipOrientation GetOrientation(string orientation)
        {
            if (orientation.Equals("Vertical"))
                return ShipOrientation.Vertical;
            else
              return ShipOrientation.Horizontal;
        }
        private int GetLength(string length)
        {
            return Convert.ToInt32(length);
            
        }
        private Point[] SetPosition(Point Startingpoint, ShipOrientation Orientation, int Length)
        {

            Point[] points = new Point[Length];
           
            for (int i=0; i<Length; i++)
            {
                 points[i] = new Point(Startingpoint.X, Startingpoint.Y);

                if (Orientation == ShipOrientation.Horizontal)
                {
                    Startingpoint.Y++;
                    int Y = Startingpoint.Y;
                    if (Startingpoint.X == 0)
                    {
                        int X = Startingpoint.X;
                    }
                }
                else if (Orientation == ShipOrientation.Vertical)
                        {
                    Startingpoint.X++;
                    int X = Startingpoint.X;
                    if (Startingpoint.Y == 0)
                    {
                        int Y = Startingpoint.Y;
                    }
                }


            }
            return points;

        }
    }
}

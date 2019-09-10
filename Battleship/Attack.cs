using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Battleship
{
    public class Attack
    {
        public Point HitPosition { get; set; }
        public Attack(string hitPosition)
        {
            HitPosition = GetHitPosition(hitPosition);
        }
        private Point GetHitPosition(string hitPosition)
        {
            string[] HitPoints = hitPosition.Split(',');
            int coordinateX = int.Parse(HitPoints[0]);
            int coordinateY = int.Parse(HitPoints[1]);
            return new Point(coordinateX, coordinateY);

        }
    }
}
        


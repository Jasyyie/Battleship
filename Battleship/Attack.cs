using System;

namespace Battleship
{
    public class Attack
    {
        public int[,] HitPosition { get; set; }

        public void HitOrMiss(Ship ship)
        {
            if (HitPosition == ship.Position)
                Console.WriteLine("Hit");
            else Console.WriteLine("Miss");
        }
    }
}

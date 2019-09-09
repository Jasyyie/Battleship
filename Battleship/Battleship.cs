using System;

namespace Battleship
{
    public class Battleship
    {
        public Battleship()
        {
            Board = new int[10, 10];
        }
        public int[,] Board { get; set; }
    }
}

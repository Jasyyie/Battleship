using System;

namespace Battleship
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Board!, Place the ship by  Entering starting point-  0,0 stands for x and y coordinates, orientation - Horizontal or vertical, Length - 2 ");
            var a = Console.ReadLine();
            string[] shipParameters = a.Split(' ');
            var ship = new Ship(shipParameters[0], shipParameters[1], shipParameters[2]);
            int[,] board = new int[10, 10];
            PlaceTheShip (board,  ship);
            Console.WriteLine("Ship has been placed position is saved, please enter hit coordinates");
            int i = 0;
            while (i < 100)
            {
                var d = Console.ReadLine();
                var attack = new Attack(d);
                bool hitormiss = HitOrMiss(board, attack);
                var result = HitorMissReturn(hitormiss);
                Console.WriteLine(result);
               
            }
        }

        /// <summary>
        /// Places ship on Board and saving ship position as 9
        /// </summary>
        public static void PlaceTheShip(int[,] board, Ship ship)
        {
            for (int i = 0; i < ship.Position.Length; i++)
            {
                board[ship.Position[i].X, ship.Position[i].Y] = 9;
            }
        }

        /// <summary>
        /// Returns Hit, Miss or if coordinates are already typed 
        /// </summary>
        public static bool HitOrMiss(int[,] board, Attack attack)
        {
            if (board[attack.HitPosition.X, attack.HitPosition.Y] == -1)
            {
                Console.WriteLine("Coordinates Already Hit");
                return false;
            }
            
            if (board[attack.HitPosition.X, attack.HitPosition.Y] == 1)
            {
                Console.WriteLine("Coordinates Already tried and missed");
                return false;
            }
            if (board[attack.HitPosition.X,attack.HitPosition.Y]==9)
                {
                board[attack.HitPosition.X, attack.HitPosition.Y] = -1;
                return true;
                }
                else
                {
                board[attack.HitPosition.X, attack.HitPosition.Y] = 1;
                return false;
            }
        }

        /// <summary>
        /// Return Hit or Miss string 
        /// </summary>
        public static string HitorMissReturn(bool hitormiss)
        {
          
            if (hitormiss == true)
            {
              
                return "Hit";
               
            }
            else 
            {
                return "Miss";
            }
        }
    }

    }



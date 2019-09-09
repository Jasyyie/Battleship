using System;
using System.Threading;

namespace Battleship
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //     new Thread(Go).Start();      // Call Go(  ) on a new thread
            //     Go();
            // }
            // private void Go()
            // {

            Console.WriteLine("Hello World!");
            var name = Console.ReadLine();
            Console.Readline();
            Console.Read();
            Console.ReadKey();

            Console.WriteLine("Welcome to the Board");
            string B = Console.WriteLine("Place the ship, Please provide Starting, Orientation, Length");
            Console.ReadLine(B);
        }

    }
}


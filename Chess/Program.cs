using System;

namespace New_Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Setup.StartGame();
            while (1 == 1)
            {
                Setup.printBoard();
                Setup.TakeTurn();
                Console.WriteLine("---------------------------");
            }
        }
    }
}

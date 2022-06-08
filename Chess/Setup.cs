using System;
using System.Collections.Generic;
using System.Text;

namespace New_Chess
{
    class Setup
    {
        //PROPERTIES
        static public string[,] allRows = new string[8, 8];

        //METHODS

        static public void startGame()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    allRows[i, j] = "~";
                }
            }
            for (int i = 0; i < 8; i++)
            {
                allRows[1, i] = "P";
            }
            allRows[0, 0] = "R";
            allRows[0, 1] = "H";
            allRows[0, 2] = "B";
            allRows[0, 3] = "Q";
            allRows[0, 4] = "K";
            allRows[0, 5] = "B";
            allRows[0, 6] = "H";
            allRows[0, 7] = "R";

            for (int i = 0; i < 8; i++)
            {
                allRows[6, i] = "p";
            }
            allRows[7, 0] = "r";
            allRows[7, 1] = "h";
            allRows[7, 2] = "b";
            allRows[7, 3] = "q";
            allRows[7, 4] = "k";
            allRows[7, 5] = "b";
            allRows[7, 6] = "h";
            allRows[7, 7] = "r";

            printBoard();
        }
        static public void movePiece()
        {
            Console.WriteLine();
            Console.WriteLine("Choose a piece");
            int x = (int.Parse(Console.ReadLine()) - 1);
            int y = (int.Parse(Console.ReadLine()) - 1);

            Console.WriteLine("Where would you like to move it?");
            int x2 = (int.Parse(Console.ReadLine()) - 1);
            int y2 = (int.Parse(Console.ReadLine()) - 1);
            //if (x == 255)
            //{
            //    startGame();
            // }
            // else
            // {
            allRows[x2, y2] = allRows[x, y];
            allRows[x, y] = "~";
            Console.WriteLine();
            printBoard();
            // }
        }
        public static void printBoard()
        {
            Console.WriteLine("  H G F E D C B A");

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (j == 0)
                    {
                        Console.Write((i + 1) + "|");
                    }
                    Console.Write(allRows[i, j] + "|");
                }
                Console.WriteLine();
            }
        }
    }
}

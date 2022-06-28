using System;
using System.Collections.Generic;
using System.Text;
using New_Chess.Classes.Pieces;
using New_Chess.Classes;
using System.IO;

namespace New_Chess
{
    public abstract class Setup
    {
        //PROPERTIES
        static public ChessPiece[,] Board = new ChessPiece[8, 8];
        static public List<ChessPiece> allPieces = new List<ChessPiece>();

        //METHODS
        static public void StartGame()
        {
            //fills all with ~
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Board[i, j] = null;
                }
            }

            #region create white pieces
            Rook wRook1 = new Rook("WR1", "White", new int[] { 0, 0 });
            Horse wHorse1 = new Horse("WH1", "White", new int[] { 0, 1 });
            Bishop wBishop1 = new Bishop("WB1", "White", new int[] { 0, 2 });
            Queen wQueen = new Queen("W Q", "White", new int[] { 0, 3 });
            King wKing = new King("W K", "White", new int[] { 0, 4 });
            Bishop wBishop2 = new Bishop("WB2", "White", new int[] { 0, 5 });
            Horse wHorse2 = new Horse("WH2", "White", new int[] { 0, 6 });
            Rook wRook2 = new Rook("WR2", "White", new int[] { 0, 7 });
            Pawn wPawn1 = new Pawn("WP1", "White", new int[] { 1, 0 });
            Pawn wPawn2 = new Pawn("WP2", "White", new int[] { 1, 1 });
            Pawn wPawn3 = new Pawn("WP3", "White", new int[] { 1, 2 });
            Pawn wPawn4 = new Pawn("WP4", "White", new int[] { 1, 3 });
            Pawn wPawn5 = new Pawn("WP5", "White", new int[] { 1, 4 });
            Pawn wPawn6 = new Pawn("WP6", "White", new int[] { 1, 5 });
            Pawn wPawn7 = new Pawn("WP7", "White", new int[] { 1, 6 });
            Pawn wPawn8 = new Pawn("WP8", "White", new int[] { 1, 7 });
            #endregion


            #region assign white pieces to board
            Board[0, 0] = wRook1;
            Board[0, 1] = wHorse1;
            Board[0, 2] = wBishop1;
            Board[0, 3] = wQueen;
            Board[0, 4] = wKing;
            Board[0, 5] = wBishop2;
            Board[0, 6] = wHorse2;
            Board[0, 7] = wRook2;
            Board[1, 0] = wPawn1;
            Board[1, 1] = wPawn2;
            Board[1, 2] = wPawn3;
            Board[1, 3] = wPawn4;
            Board[1, 4] = wPawn5;
            Board[1, 5] = wPawn6;
            Board[1, 6] = wPawn7;
            Board[1, 7] = wPawn8;
            #endregion


            //make sure to switch king and queen sides
            #region create black pieces
            Rook bRook1 = new Rook("BR1", "Black", new int[] { 7, 0 });
            Horse bHorse1 = new Horse("BH1", "Black", new int[] { 7, 1 });
            Bishop bBishop1 = new Bishop("BB1", "Black", new int[] { 7, 2 });
            Queen bQueen = new Queen("B Q", "Black", new int[] { 7, 3 });
            King bKing = new King("B K", "Black", new int[] { 7, 4 });
            Bishop bBishop2 = new Bishop("BB2", "Black", new int[] { 7, 5 });
            Horse bHorse2 = new Horse("BH2", "Black", new int[] { 7, 6 });
            Rook bRook2 = new Rook("BR2", "Black", new int[] { 7, 7 });
            Pawn bPawn1 = new Pawn("BP1", "Black", new int[] { 6, 0 });
            Pawn bPawn2 = new Pawn("BP2", "Black", new int[] { 6, 1 });
            Pawn bPawn3 = new Pawn("BP3", "Black", new int[] { 6, 2 });
            Pawn bPawn4 = new Pawn("BP4", "Black", new int[] { 6, 3 });
            Pawn bPawn5 = new Pawn("BP5", "Black", new int[] { 6, 4 });
            Pawn bPawn6 = new Pawn("BP6", "Black", new int[] { 6, 5 });
            Pawn bPawn7 = new Pawn("BP7", "Black", new int[] { 6, 6 });
            Pawn bPawn8 = new Pawn("BP8", "Black", new int[] { 6, 7 });
            #endregion


            #region assign black pieces to board
            Board[7, 0] = bRook1;
            Board[7, 1] = bHorse1;
            Board[7, 2] = bBishop1;
            Board[7, 3] = bQueen;
            Board[7, 4] = bKing;
            Board[7, 5] = bBishop2;
            Board[7, 6] = bHorse2;
            Board[7, 7] = bRook2;
            Board[6, 0] = bPawn1;
            Board[6, 1] = bPawn2;
            Board[6, 2] = bPawn3;
            Board[6, 3] = bPawn4;
            Board[6, 4] = bPawn5;
            Board[6, 5] = bPawn6;
            Board[6, 6] = bPawn7;
            Board[6, 7] = bPawn8;
            #endregion


            #region all pieces to a list
            allPieces.Add(wRook1);
            allPieces.Add(wHorse1);
            allPieces.Add(wBishop1);
            allPieces.Add(wQueen);
            allPieces.Add(wKing);
            allPieces.Add(wBishop2);
            allPieces.Add(wHorse2);
            allPieces.Add(wRook2);
            allPieces.Add(wPawn1);
            allPieces.Add(wPawn2);
            allPieces.Add(wPawn3);
            allPieces.Add(wPawn4);
            allPieces.Add(wPawn5);
            allPieces.Add(wPawn6);
            allPieces.Add(wPawn7);
            allPieces.Add(wPawn8);
            allPieces.Add(bRook1);
            allPieces.Add(bHorse1);
            allPieces.Add(bBishop1);
            allPieces.Add(bQueen);
            allPieces.Add(bKing);
            allPieces.Add(bBishop2);
            allPieces.Add(bHorse2);
            allPieces.Add(bRook2);
            allPieces.Add(bPawn1);
            allPieces.Add(bPawn2);
            allPieces.Add(bPawn3);
            allPieces.Add(bPawn4);
            allPieces.Add(bPawn5);
            allPieces.Add(bPawn6);
            allPieces.Add(bPawn7);
            allPieces.Add(bPawn8);
            #endregion

        }
        static private ChessPiece pieceToMove = null;
        static private void choosePiece()
        {
            Console.WriteLine("\nchoose piece:");
            string rawSearchPiece = Console.ReadLine();
            string searchPiece = rawSearchPiece.ToUpper();



            foreach (ChessPiece piece in Setup.allPieces)
            {
                if (piece.Name == searchPiece)
                {
                    pieceToMove = piece;
                }
            }

            if (pieceToMove == null)
            {
                Console.WriteLine("invalid piece");
                choosePiece();
                //return pieceToMove;
            }
            //else
            //{
            //return pieceToMove;
            //}

        }
        static private int[] destination;
        static private void chooseDestination()
        {

            Console.WriteLine("\nWhere would you like to move it?");
            string end = Console.ReadLine();

            
                #region find X
                int endX = 0;
                try
                {
                    //endX = int.Parse(end.Substring(0, 1));
                    if (int.Parse(end.Substring(0, 1)) >= 1 && int.Parse(end.Substring(0, 1)) <= 8)
                    {
                        endX = int.Parse(end.Substring(0, 1)) - 1;

                    }
                    else
                    {
                        Console.WriteLine("invalid location2");
                        chooseDestination();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("invalid location1");
                    chooseDestination();
                }
            #endregion
            if (destination == null)
            {
                #region find Y
                string endStringY = end.Substring(1, 1);
                int endY = 0;
                if (endStringY == "H" || endStringY == "h")
                {
                    endY = 0;
                }
                else if (endStringY == "G" || endStringY == "g")
                {
                    endY = 1;
                }
                else if (endStringY == "F" || endStringY == "f")
                {
                    endY = 2;
                }
                else if (endStringY == "E" || endStringY == "e")
                {
                    endY = 3;
                }
                else if (endStringY == "D" || endStringY == "d")
                {
                    endY = 4;
                }
                else if (endStringY == "C" || endStringY == "c")
                {
                    endY = 5;
                }
                else if (endStringY == "B" || endStringY == "b")
                {
                    endY = 6;
                }
                else if (endStringY == "A" || endStringY == "a")
                {
                    endY = 7;
                }
                else
                {
                    Console.WriteLine("invalid location3");
                    chooseDestination();
                }
                #endregion

                int[] endLocation = new int[2];
                endLocation[0] = endX;
                endLocation[1] = endY;

                destination = endLocation;
            }
        }
        static public void TakeTurn()
        {
            choosePiece();
            ChessPiece chosenPiece = pieceToMove;
            int[] startLocation = chosenPiece.Location;
            chooseDestination();
            int[] endLocation = destination;
            Board[endLocation[0], endLocation[1]] = chosenPiece;
            Board[startLocation[0], startLocation[1]] = null;
            chosenPiece.Location = endLocation;

            Console.WriteLine();
        }
        public static void printBoard()
        {
            Console.WriteLine();
            Console.WriteLine("    H   G   F   E   D   C   B   A ");

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("  |---|---|---|---|---|---|---|---|");
                for (int j = 0; j < 8; j++)
                {
                    if (j == 0)
                    {
                        Console.Write((i + 1) + " |");
                    }
                    if (Board[i, j] == null)
                    {
                        Console.Write(" ~ |");
                    }
                    else
                    {
                        Console.Write(Board[i, j].Name + "|");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}

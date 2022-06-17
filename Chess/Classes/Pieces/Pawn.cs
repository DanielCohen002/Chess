using System;
using System.Collections.Generic;
using System.Text;

namespace New_Chess.Classes.Pieces 
{
    public class Pawn : ChessPiece
    {
        public Pawn(string name, string color, int[] locatiorn)
        {
            Name = name;
            Color = color;
            Location = locatiorn;
        }
        public Pawn() { }
    }
}

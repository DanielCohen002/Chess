using System;
using System.Collections.Generic;
using System.Text;

namespace New_Chess.Classes.Pieces 
{
    public class Rook : ChessPiece
    {
        public Rook(string name, string color, int[] locatiorn)
        {
            Name = name;
            Color = color;
            Location = locatiorn;
        }
        public Rook() { }
    }
}

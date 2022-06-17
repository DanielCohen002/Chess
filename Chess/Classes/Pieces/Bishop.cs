using System;
using System.Collections.Generic;
using System.Text;

namespace New_Chess.Classes.Pieces 
{
    public class Bishop : ChessPiece
    {
        public Bishop(string name, string color, int[] locatiorn)
        {
            Name = name;
            Color = color;
            Location = locatiorn;
        }
        public Bishop() { }
    }
}

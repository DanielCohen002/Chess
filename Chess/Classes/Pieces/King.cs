using System;
using System.Collections.Generic;
using System.Text;

namespace New_Chess.Classes.Pieces 
{
    public class King : ChessPiece
    {
        public King(string name, string color, int[] locatiorn)
        {
            Name = name;
            Color = color;
            Location = locatiorn;
        }
        public King() { }
    }
}

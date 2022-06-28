using System;
using System.Collections.Generic;
using System.Text;

namespace New_Chess.Classes.Pieces 
{
    public class Queen : ChessPiece
    {
        public Queen(string name, string color, int[] location)
        {
            Name = name;
            Color = color;
            Location = location;
        }
        public Queen() { }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace New_Chess.Classes
{
    public abstract class ChessPiece
    {
        //PROPERTIES

        public string Name { get; set; }
        public string Color { get; set; }
        public bool Isdead { get; set; } = false;
        public int[] Location { get; set; }


        //METHODS
        public virtual void Move(int[] newLocation) 
        {
            this.Location = newLocation;
        }
    }
}

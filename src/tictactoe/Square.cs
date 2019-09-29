using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    public enum Player { None = 0, Hug, Kiss}

    public struct Square
    {
        public Square(Player owner)
        {
            this.Owner = owner;
        }

        public Player Owner { get; }

        public override string ToString()
        {
            switch(Owner)
            {
                case Player.None:
                    return ".";

                case Player.Kiss:
                    return "X";

                case Player.Hug:
                    return "O";

                default:
                    throw new Exception("Invalid state");
            }
        }
    }
}
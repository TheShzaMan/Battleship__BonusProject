using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBattleShip_ConsoleApp
{
    public class ShipEnd : GridSpace
    {
        private string shipEnd;
        private string Top;
        private string Bottom;
        private string Left;
        private string Right;
        public ShipEnd(string shipEnd)
        {
            this.shipEnd = shipEnd;
            TypeDisplay = "    ";
            Top = @" /\ ";
            Bottom = @" \/ ";
            Left = " <{]";
            Right = "[}> ";
        }
        public override string DisplayToGrid()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            if (shipEnd == "top")
            {
                TypeDisplay = Top;
            }
            else if (shipEnd == "bottom")
            {
                TypeDisplay = Bottom;
            }
            else if (shipEnd == "left")
            {
                TypeDisplay = Left;
            }
            else if (shipEnd == "right")
            {
                TypeDisplay = Right;
            }
            else
            {
                throw new Exception("Invalid parameter. Only top, bottom, left or right");
            }
            return TypeDisplay;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBattleShip_ConsoleApp
{
    public class ShipBody : GridSpace
    {
        private string verticalOrHorizontal;
        private string Vertical;
        private string Horizontal;
        public ShipBody(string verticalOrHorizontal)
        {
            this.verticalOrHorizontal = verticalOrHorizontal;
            TypeDisplay = "";
            Vertical = "|#| ";
            Horizontal = "[#] ";
            SpaceType = "ship";
        }
        public override string DisplayToGrid()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            if (verticalOrHorizontal == "vertical")
            {
                TypeDisplay = Vertical;
            }
            else if (verticalOrHorizontal == "horizontal")
            {
                TypeDisplay = Horizontal;
            }
            else
            {
                throw new Exception("Invalid parameter. Only 'vertical' or 'horizontal'");
            }
            return TypeDisplay;
        }
    }
}

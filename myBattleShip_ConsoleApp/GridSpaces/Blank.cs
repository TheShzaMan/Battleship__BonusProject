using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBattleShip_ConsoleApp
{
    public class Blank : GridSpace
    {

        
        public Blank()
        {
            isAvailable = true;
            TypeDisplay = " ~  ";
            SpaceType = "blank";
        }

        public override string DisplayToGrid()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            return TypeDisplay;
        }

    }
}

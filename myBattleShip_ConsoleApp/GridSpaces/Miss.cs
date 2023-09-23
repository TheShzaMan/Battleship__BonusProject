using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBattleShip_ConsoleApp
{
    public class Miss : GridSpace
    {

        public Miss()
        {
            TypeDisplay = "}*{ ";

        }

        public override string DisplayToGrid()
        {
            Console.ForegroundColor = ConsoleColor.White;
            return TypeDisplay;
        }

    }
}

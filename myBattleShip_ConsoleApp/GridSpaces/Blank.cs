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
            TypeDisplay = "~ ~ ";
            
        }

        public override string DisplayToGrid()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            return TypeDisplay;
        }

    }
}

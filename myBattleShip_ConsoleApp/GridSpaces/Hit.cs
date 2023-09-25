using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBattleShip_ConsoleApp
{
    public class Hit : GridSpace
    {
        public Hit()
        {
            TypeDisplay = "[X] ";
            SpaceType = "hit";
        }

        public override string DisplayToGrid()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            
            return TypeDisplay;
            
        }
    }
}

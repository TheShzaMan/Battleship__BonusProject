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
            TypeDisplay = "[X]|";
            
            
        }

        public override string DisplayToGrid()
        {
            
            return TypeDisplay;
        }
    }
}

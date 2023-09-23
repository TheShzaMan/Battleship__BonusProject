using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBattleShip_ConsoleApp
{
    public abstract class GridSpace
    {
        public string TypeDisplay;

        public GridSpace()
        {
        }
        public virtual string DisplayToGrid()
        {
            
           return " ";
        }
    }
}

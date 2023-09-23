using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBattleShip_ConsoleApp
{
    abstract class GamePiece 
    {
        public string Name;
        public List<GridSpace> Ship;
        public GamePiece(string name)
        {
            Name = name;
            Ship = new List<GridSpace>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBattleShip_ConsoleApp
{
    public abstract class GamePiece 
    {
        public string Id;
        public string Name;
        public List<GridSpace> HorizontalShip;
        public List<GridSpace> VerticalShip;
        public GamePiece()
        {
            string horizontalId = "h";
            string verticalId = "v";
            Name = "";
            HorizontalShip = new List<GridSpace>();
            VerticalShip = new List<GridSpace>();
          
        }
        public virtual List<GridSpace> MakeHorizontal()
        {
            return HorizontalShip;
        }
        public virtual List<GridSpace> MakeVertical()
        {
            return VerticalShip;
        }
    }
}

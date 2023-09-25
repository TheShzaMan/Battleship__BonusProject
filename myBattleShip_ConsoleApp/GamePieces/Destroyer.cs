﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBattleShip_ConsoleApp
{
    public class Destroyer : GamePiece
    {
        public Destroyer(string Id)
        {
            Name = "destroyer";
            this.Id = Id;
            if (Id == "h") { MakeHorizontal(); }
            else if (Id == "v") { MakeVertical(); }
            else { throw new ArgumentException("Invalid input. 'h' for horizontal, 'v' for vertical"); }
        }
        public override List<GridSpace> MakeHorizontal()
        {
            //Id = "h";
            HorizontalShip.Add(new ShipEnd("left"));
            HorizontalShip.Add(new ShipEnd("right"));
            return HorizontalShip;
        }
        public override List<GridSpace> MakeVertical()
        {
            //Id = "v";
            VerticalShip.Add(new ShipEnd("top"));
            VerticalShip.Add(new ShipEnd("bottom"));
            return VerticalShip;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBattleShip_ConsoleApp
{
    public class Player
    {
        public string Name;
        public GameBoard MyBoard;
        public GameBoard EnemyBoard;
        public List<GamePiece> MyShips;
        public Player(string name)
        {
            Name = name;
            MyBoard = new GameBoard("MyBoard");
            EnemyBoard = new GameBoard("EnemyBoard");
            MyShips = new List<GamePiece>()
            {
                new BattleShip("h"), 
                new BattleShip("v"), 
                new Destroyer("h"),
                new Destroyer("v"),
                new Submarine("h"),
                new Submarine("v"),
                new AircraftCarrier("h"),
                new AircraftCarrier("v")
            };
            
        }
        public GamePiece this[int index]
        {
            get
            {
                return MyShips[index];
            }
            set
            {
                MyShips[index] = value;
            }
        }
        public void DisplayBoard(GameBoard gameBoard)
        {
            Console.WriteLine($"\n{Name} : { gameBoard.Name}");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("    --- --- --- --- --- --- --- --- --- ---"); //best version
            //Console.WriteLine("    ---|---|---|---|---|---|---|---|---|---");
            //Console.WriteLine("    _______________________________________");
            for (int i = 0; i < 9; i++)
            {
                Console.ResetColor();
                Console.Write(gameBoard.rowNames[i + 1]);
                for (int j = 0; j < 10; j++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(gameBoard.Grid[i + 1][j + 1].DisplayToGrid());
                    Console.ResetColor();
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("   |~ ~|~ ~|~ ~|~ ~|~ ~|~ ~|~ ~|~ ~|~ ~|~ ~|"); //best version
                //Console.WriteLine("    --- --- --- --- --- --- --- --- --- ---");
                //Console.WriteLine("   |---|---|---|---|---|---|---|---|---|---|");
                Console.ResetColor();
            }
            Console.Write(gameBoard.rowNames[10]);
            for (int k = 0; k < 10; k++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(gameBoard.Grid[10][k + 1].DisplayToGrid());
            }
            //// The following is the bottom row of board 
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine();
            Console.WriteLine("   |~ ~|~ ~|~ ~|~ ~|~ ~|~ ~|~ ~|~ ~|~ ~|~ ~|"); //best version
            //Console.WriteLine("    --- --- --- --- --- --- --- --- --- ---");
            //Console.WriteLine("   |---|---|---|---|---|---|---|---|---|---|");
           // Console.WriteLine("    ___|___|___|___|___|___|___|___|___|___");
            Console.ResetColor();
            foreach (var columnName in gameBoard.columnNames)
            {
                Console.Write(columnName + "   ");
            }
            Console.WriteLine();
        }
        public void PlaceShip(int row, int column, string name, string Id)
        {
            var ship = MyShips.Find(s => s.Name == name && s.Id == Id );
           
            bool canPlace = false;
            if( Id == "h" )
            {
                List<GridSpace> spaceToCheck = new List<GridSpace>();
                for (int i = 0; i < ship.HorizontalShip.Count; i++)
                {
                    if ((row > 0 && row < 11) && ((column + i) > 0 && (column + i) < 11))
                    {
                        spaceToCheck.Add(MyBoard.Grid[row][column + i]);
                    }
                    else
                    {
                        Console.WriteLine("Unable to place ship in this location. All spaces must be playable and unoccupied");
                        // Must get new user input here and loop back to before spaceToCheck instantiated;
                        break;
                    }
                }

                if (spaceToCheck.All(s => s.isAvailable))
                {
                    canPlace = true;
                    for (int i = 0; i < ship.HorizontalShip.Count; i++)
                    {
                        MyBoard.Grid[row][column + i] = ship.HorizontalShip[i];
                    }
                }
                else
                {
                    Console.WriteLine("Unable to place ship in this location. All spaces must be playable and unoccupied");
                    // Must get new user input here and loop back to before spaceToCheck instantiated;
                }
            }
            else if (Id == "v")
            {
                
                List<GridSpace> spaceToCheck = new List<GridSpace>();
                for (int i = 0; i < ship.VerticalShip.Count; i++)
                {
                    if (((row + i) > 0 && (row + i) < 11) && (column > 0 && column < 11))
                    {
                        spaceToCheck.Add(MyBoard.Grid[row + i][column]);
                    }
                    else
                    {
                        Console.WriteLine("Unable to place ship in this location. All spaces must be playable and unoccupied");
                        // Must get new user input here and loop back to before spaceToCheck instantiated;
                        break;
                    }
                }

                if (spaceToCheck.All(s => s.isAvailable))
                {
                    canPlace = true;
                    for (int i = 0; i < ship.VerticalShip.Count; i++)
                    {
                        MyBoard.Grid[row + i][column] = ship.VerticalShip[i];
                    }
                }
                else
                {
                    Console.WriteLine("Unable to place ship in this location. All spaces must be playable and unoccupied");
                    // Must get new user input here and loop back to before spaceToCheck instantiated;

                }
            }
            DisplayBoard(MyBoard);
        }
    }
}

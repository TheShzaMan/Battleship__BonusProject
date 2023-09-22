using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//using myBattleShip_ConsoleApp;

namespace myBattleShip_ConsoleApp
{
    public class GameBoard
    {
        public string Name;
        public List<List<GridSpace>> Grid;
        public string[] columnNames;
        public string[] rowNames;
        public GameBoard(string name) // Either "MyBoard" or "EnemyBoard"
        {
            Name = name;
            //List<GridSpace> typesOfGridSpaces = new List<GridSpace>() { Blank, Hit, Miss, Ship, ShipFront, ShipRear};
            columnNames = new string[11] { null, "  A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            rowNames = new string[11] { null, " 1 |", " 2 |", " 3 |", " 4 |", " 5 |", " 6 |", " 7 |", " 8 |", " 9 |", "10 |" };
            Grid = new List<List<GridSpace>>();
            for (int i = 0; i < 11; i++)
            {
                Grid.Add(new List<GridSpace>());

                for (int j = 0; j < 11; j++)
                {
                    Grid[i].Add(new Blank());
                }
            }
        }
            
           
        
       
        public void DisplayHit(int letterX, int numberY)
        {
            //GridSpace userInput = new Hit();
            //PlayArea[letterX][letterY] = 
        }
    }
}

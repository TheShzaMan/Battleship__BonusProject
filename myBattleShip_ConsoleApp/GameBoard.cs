using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using myBattleShip_ConsoleApp.GridSpaces;

namespace myBattleShip_ConsoleApp
{
    internal class GameBoard
    {
        public List<List<GridSpace>> PlayArea;
        public string[] xAxis;
        public string[] yAxis;
        public GameBoard()
        {
            //List<GridSpace> typesOfGridSpaces = new List<GridSpace>() { Blank, Hit, Miss, Ship, ShipFront, ShipRear};
            xAxis = new string[11] { null, " A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            yAxis = new string[11] { null, "0 |", "1 |", "2 |", "3 |", "4 |", "5 |", "6 |", "7 |", "8 |", "9 |" };
            foreach (var x in xAxis)
            {
                Console.Write(x + "   ");
            }
            Console.WriteLine("\n   --- --- --- --- --- --- --- --- --- ---");
            PlayArea = new List<List<GridSpace>>();

            for (int i = 0; i < 10; i++)
            {
                PlayArea.Add(new List<GridSpace>());

                for (int j = 0; j < 11; j++)
                {
                    PlayArea[i].Add(new Blank());
                }
            }
            DisplayBoard();
            Console.WriteLine("Make selection (letter, number)");
            Console.Read();

            GridSpace userInput = new Hit();
            PlayArea[3][3] = userInput;
            DisplayBoard();
        }
        public void DisplayBoard()
        {
            foreach (var x in xAxis)
            {
                Console.Write(x + "   ");
            }
            Console.WriteLine("\n   --- --- --- --- --- --- --- --- --- ---");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(yAxis[i + 1] );
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(PlayArea[i][j].DisplayToGrid());
                }
                Console.WriteLine("\n");
            }
        }
        public void DisplayHit(int letterX, int numberY)
        {
            GridSpace userInput = new Hit();
            PlayArea[letterX][letterY] = 
        }
    }
}

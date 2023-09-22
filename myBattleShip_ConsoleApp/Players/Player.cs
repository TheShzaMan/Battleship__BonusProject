using System;
using System.Collections.Generic;
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
        public Player(string name)
        {
            Name = name;
            MyBoard = new GameBoard("MyBoard");
            EnemyBoard = new GameBoard("EnemyBoard");
            
        }
        public void DisplayBoard(GameBoard gameBoard)
        {
            Console.WriteLine($"{Name} : { gameBoard.Name}\n");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(gameBoard.rowNames[i + 1]);
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(gameBoard.Grid[i + 1][j + 1].DisplayToGrid());

                }
                Console.WriteLine("\n");
            }
           // Console.WriteLine("    --- --- --- --- --- --- --- --- --- ---");
            foreach (var columnName in gameBoard.columnNames)
            {
                Console.Write(columnName + "   ");
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
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
        public Player(string name)
        {
            Name = name;
            MyBoard = new GameBoard("MyBoard");
            EnemyBoard = new GameBoard("EnemyBoard");
            
        }
        public void DisplayBoard(GameBoard gameBoard)
        {
            Console.WriteLine($"{Name} : { gameBoard.Name}\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("    --- --- --- --- --- --- --- --- --- ---");
            //Console.WriteLine("    ---|---|---|---|---|---|---|---|---|---");
            //Console.WriteLine("    _______________________________________");
            for (int i = 0; i < 9; i++)
            {
                Console.ResetColor();
                Console.Write(gameBoard.rowNames[i + 1]);
                for (int j = 0; j < 10; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(gameBoard.Grid[i + 1][j + 1].DisplayToGrid());
                    Console.ResetColor();
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                //Console.WriteLine("    --- --- --- --- --- --- --- --- --- ---");
                Console.WriteLine("   |---|---|---|---|---|---|---|---|---|---|");
                Console.ResetColor();
            }
            Console.Write(gameBoard.rowNames[10]);
            for (int k = 0; k < 10; k++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(gameBoard.Grid[10][k + 1].DisplayToGrid());
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            //Console.WriteLine("    --- --- --- --- --- --- --- --- --- ---");
            Console.WriteLine("   |---|---|---|---|---|---|---|---|---|---|");
           // Console.WriteLine("    ___|___|___|___|___|___|___|___|___|___");
            Console.ResetColor();
            foreach (var columnName in gameBoard.columnNames)
            {
                Console.Write(columnName + "   ");
            }
            Console.WriteLine();
        }
    }
}

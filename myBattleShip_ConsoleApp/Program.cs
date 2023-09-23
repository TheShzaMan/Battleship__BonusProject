using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;



namespace myBattleShip_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            //game.PlayerOne.DisplayBoard(game.PlayerOne.MyBoard);
            
            Console.WriteLine("Make selection (letter, number)");
            //Console.Read(); //circle back for good location for this and add connection to user input and program

            //DisplayHit(3, 3);
            //GridSpace userInput = new Hit();
            //game.PlayerOne.MyBoard.DisplayHit [4][9] = userInput;
            game.PlayerOne.EnemyBoard.Grid[4][10] = new Hit();
            game.PlayerOne.EnemyBoard.Grid[6][6] = new Miss();
            game.PlayerOne.EnemyBoard.Grid[4][2] = new ShipEnd("left");
            game.PlayerOne.EnemyBoard.Grid[4][3] = new ShipBody("horizontal");
            game.PlayerOne.EnemyBoard.Grid[4][4] = new ShipEnd("right");

            game.PlayerOne.DisplayBoard(game.PlayerOne.EnemyBoard);






            //T[,] gameBoard = new T[rows, columns];
            //int[,] gameBoard = new int[11, 11];
            //gameBoard[0, 0] = 0;

            //for (int i = 0; i < gameBoard.GetLength(0); i++)
            //{
            //    for (int j = 0; j < gameBoard.GetLength(0); j++)
            //    {
            //        Console.Write(gameBoard[i, j] + " ");
            //    }
            //    Console.WriteLine(); 
            //}
        }
    }
}
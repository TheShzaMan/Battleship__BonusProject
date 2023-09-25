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

            
            
            //game.PlayerOne.PlaceShip( 2, 1, "battleship", "h");
            //game.PlayerOne.PlaceShip( 6, 4, "submarine", "h");
            //game.PlayerOne.PlaceShip( 10, 9, "destroyer", "h");
            //game.PlayerOne.PlaceShip( 3, 6, "aircraftCarrier", "h");
            
            //game.PlayerOne.PlaceShip(7, 6, "battleship", "v");
            //game.PlayerOne.PlaceShip(6, 10, "submarine", "v");
            //game.PlayerOne.PlaceShip(3, 7, "destroyer", "v");
            //game.PlayerOne.PlaceShip(3, 1, "aircraftCarrier", "v");


            





            game.PlayerOne.DisplayBoard(game.PlayerOne.MyBoard);
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
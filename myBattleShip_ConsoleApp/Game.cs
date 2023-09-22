using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBattleShip_ConsoleApp
{
    internal class Game
    {
        //has a player1, player2;  PLAYERS will have 2 GameBoards: myBoard, opponentBoard
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public Game()
        {
            PlayerOne = new Player("PlayerOne");
            PlayerTwo = new Player("PlayerTwo");
        }

        
    }
}

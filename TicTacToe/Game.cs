﻿using Program;

namespace TicTacToe
{
    public class Game
    {
        private List<Player> Players;
        private Player ActualPlayer;
        private Board Gameboard;

        public Game() 
        {
            Players = new List<Player>();
            Gameboard = new Board();
            InitializingGame();
        }
        public void GamePhase()
        {
            Gameboard.PrintBoard();
            while (true) 
            {
                int coordinate = GetMove();
                PlaceSymbol(coordinate);
                Gameboard.PrintBoard();
                Gameboard.CheckWinner(ActualPlayer);
                if (ActualPlayer.HasWon == true)
                {
                    Environment.Exit(0);
                }
                ChangePlayer();
            }
        }
        public void InitializingGame()
        {

            var player1 = GetPlayer();
            var player2 = GetPlayer();
            Players.Add(player1);
            Players.Add(player2);
            ActualPlayer = player1;
        }
        public void ChangePlayer()
        {
            if (ActualPlayer == Players[0])
            { 
                ActualPlayer = Players[1];
            }
            else
            {
                ActualPlayer = Players[0];
            }
        }
        public Player GetPlayer()
        {
            Console.WriteLine("Player name?");
            var name = Console.ReadLine()!;

            Console.WriteLine($"Which character would you like to be {name}? X or O?");
            var x = Console.ReadLine()!;
            char symbol1 = Convert.ToChar(x);
            var symbol = char.ToUpper(symbol1);

            Player player = new(name, symbol);
            return player;
        }
        public int GetMove()
        {
            Console.WriteLine("Give a number:");
            string coord = Console.ReadLine()!;
            int coordinate = Convert.ToInt32(coord);
            return coordinate;
        }
        public void PlaceSymbol(int coordinate)
        {
            if ( 1<= coordinate && coordinate <= 9)
            {
                Gameboard.Place(coordinate, ActualPlayer.GetSymbol(), out bool change);
                if (change)
                {
                    ChangePlayer();
                }
            }
            else
            {
                Console.WriteLine("Number out of range");
                ChangePlayer();
            }
        }
    }
}

using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        private char[] arr = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

        public void PrintBoard()
        {

            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }

        public void Place(int coordinate, char symbol, out bool change)
        {
            change = false;
            if (arr[coordinate] == ' ')
            {
                arr[coordinate] = symbol;
            }
            else
            {
                Console.WriteLine("Place already taken");
                change = true;
            }
        }
        public bool CheckWinner()
        {
            if (arr[1] == arr[2] && arr[1] == arr[3] && arr[1] != ' ' ||
                arr[4] == arr[5] && arr[4] == arr[6] && arr[4] != ' ' ||
                arr[7] == arr[8] && arr[8] == arr[9] && arr[7] != ' ' ||
                arr[1] == arr[4] && arr[4] == arr[7] && arr[1] != ' ' ||
                arr[2] == arr[5] && arr[5] == arr[8] && arr[2] != ' ' ||
                arr[3] == arr[6] && arr[6] == arr[9] && arr[3] != ' ' ||
                arr[1] == arr[5] && arr[5] == arr[9] && arr[1] != ' ' ||
                arr[3] == arr[5] && arr[5] == arr[7] && arr[3] != ' ')
            {
                Console.WriteLine("You won the game!");
                return true;
            }
            else if(arr[1] != ' ' && arr[2] != ' ' && arr[3] != ' ' && arr[4] != ' ' && arr[5] != ' ' &&
                arr[6] != ' ' && arr[7] != ' ' && arr[8] != ' ' && arr[9] != ' ')
            {
                Console.WriteLine("Its a draw!");
                return true;
            }
            return false;
        }
    }
}
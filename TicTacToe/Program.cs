using Program;
using System.Net.WebSockets;

namespace TicTacToe
{
    class Program
    {

        public static void Main(string[] args)
        {
            Board();
            GetPlayer();
        }
        public static void Board()
        {
            char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

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
        public static void GetPlayer()
        {
            Console.WriteLine("Player1 name?");
            string name1 = Console.ReadLine()!;
            Console.WriteLine("Player2 name?");
            string name2 = Console.ReadLine()!;
            Console.WriteLine($"Which character would you like to be {name1}? X or O?");
            int x = Console.Read();
            char symbol1 = Convert.ToChar(x);
            //symbol1.ToUpper();
            char symbol2;
            if (symbol1 == 'X')
            {
                symbol2 = 'O';
            }
            else
            {
                symbol2 = 'X';
            }
            Player player1 = new(name1, symbol1);
            Player player2 = new(name2, symbol2);
            Console.WriteLine(name1);
            Console.WriteLine(name2);
            Console.WriteLine(symbol1);
            Console.WriteLine(symbol2);
        }

    }
}

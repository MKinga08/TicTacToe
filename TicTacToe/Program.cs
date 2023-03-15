using Program;
using System.Data.SqlTypes;
using System.Net.WebSockets;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;

namespace TicTacToe
{
    class Program
    {

        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static void Main(string[] args)
        {
            Board();
            var player1 = new Player("scb",'Q');
            player1.ChangeSymbol('k');
           
        }
        public static void Board()
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
        
        public void CheckWinner()
        {
        
        }
    }
}

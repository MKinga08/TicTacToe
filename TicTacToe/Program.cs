using Program;
using System.Data.SqlTypes;
using System.Net.WebSockets;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;

namespace TicTacToe
{
    class Program
    {
        public static void Main(string[] args)
        {
            var game = new Game();
            game.GamePhase();
        }
        
    }
}

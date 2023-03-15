using System;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    public class Player
	{
		private string name;
        private char symbol;
        public int MyProperty { get; set; } = 1;


        public Player(string aName, char aSymbol)
        {
            name = aName;
            symbol = aSymbol;
        }
        public Player GetPlayer()
        {
            Console.WriteLine("Player name?");
            name = Console.ReadLine()!;

            Console.WriteLine($"Which character would you like to be {name}? X or O?");
            int x = Console.Read();
            char symbol1 = Convert.ToChar(x);

            symbol = char.ToUpper(symbol1);
            
            Player player = new(name, symbol);
            return player;
        }
        public void ChangeSymbol(char str)
        {
            symbol = str;
        }
    }
}

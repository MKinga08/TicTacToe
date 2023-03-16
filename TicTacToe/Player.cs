using System;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    public class Player
	{
		public string name;
        private char symbol;
        public bool HasWon { get; set; } = default;
        public Player(string aName, char aSymbol)
        {
            name = aName;
            symbol = aSymbol;
        }
        public char GetSymbol() 
        {
            return symbol; 
        }
    }
}

using System;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    public class Player
	{
		private string name;
        private char symbol;

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

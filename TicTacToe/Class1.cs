using System;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    public class Player
	{
		public string name;
        public char symbol;

        public Player(string aName, char aSymbol)
        {
            name = aName;
            symbol = aSymbol;
        }
    }
}

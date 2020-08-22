using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastChars
{
    class Game
    {
        string wordA;
        string wordB;
        string result;

        public void Play()
        {
            Console.WriteLine("\nEnter the first word to be rearranged: ");
            wordA = Console.ReadLine();
            if (wordA.Length == 0)
            {
                wordA = "@";
            }

            Console.WriteLine("\nNow enter the second word to be rearranged: ");
            wordB = Console.ReadLine();
            if (wordB.Length == 0)
            {
                wordB = "@";
            }

            result = Rearrange(wordA, wordB);
            Console.WriteLine("\nThe result IS: {0}!", result);
            Console.ReadLine();
        }

        private string Rearrange(string x, string y)
        {
            result = (x.Substring(0, 1) + (y.Substring((y.Length - 1), 1)));
            return result;
        }
    }
}

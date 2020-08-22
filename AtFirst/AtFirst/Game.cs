using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtFirst
{
    class Game
    {
        string word;
        string result;
        string firstTwo;

        public void Play()
        {
            Console.WriteLine("\nPlease enter the word you wish to shorten to 2 characters: ");
            word = Console.ReadLine();

            result = Rearrange(word);
            Console.WriteLine("\nThe result is: {0}", result);
            Console.ReadLine();
        }

        private string Rearrange(string x)
        {
            if (x.Length >= 2)
            {
                firstTwo = x.Substring(0, 2);
            }

            else if (x.Length == 1)
            {
                firstTwo = x.Substring(0, 1) + "@";
            }

            else if (x.Length == 0)
            {
                firstTwo = "@@";
            }
            return firstTwo;
        }
    }
}

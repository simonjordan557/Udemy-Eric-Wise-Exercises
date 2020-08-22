using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleTwo
{
    class Game
    {
        string word;
        string first;
        string last;
        string result;
        string total;

        public void Play()
        {
            Console.WriteLine("Enter the word to be adjusted (EVEN number of characters, plaease: ");
            word = Console.ReadLine();

            if ((word.Length % 2) != 0)
            {
                Console.WriteLine("\nI SAID EVEN NUMBER OF CHARACTERS, MOTHERFUCKER!!!!!!!");
                Play();
            }

            else
            {
                result = Rearrange(word);
                Console.WriteLine("\nYour middle letters are: {0}", result);
                Console.ReadLine();
            }
        }

        private string Rearrange(string x)
        {
            first = x.Substring(((x.Length / 2) - 1), 1);
            last = x.Substring((x.Length / 2), 1);
            total = first + last;
            return total;
        }
    }
}

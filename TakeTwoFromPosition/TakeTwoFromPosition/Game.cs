using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeTwoFromPosition
{
    class Game
    {
        string word;
        int n;
        string nString;
        string result;

        public void Play()
        {
            Console.WriteLine("\nPlease enter the word to be doctored (MINIMUM 2 CHARACTERS): ");
            word = Console.ReadLine();

            if (word.Length < 2)
            {
                Console.WriteLine("\nDURRRRRRRR I SAID MINIMUM OF 2 CHARACTERS!!!");
                Play();
            }

            else
            {
                Console.WriteLine("\nPlease enter the position at which you want to take the 2-character slice. ");
                nString = Console.ReadLine();
                n = int.Parse(nString);

                result = Rearrange(word, n);
                Console.WriteLine("\nThe result is: {0}.", result);
                Console.ReadLine();
            }
        }

        private string Rearrange(string x, int y)
        {
            if ((x.Length - y) < 2)
            {
                result = x.Substring(0, 2);
            }

            else
            {
                result = x.Substring(y, 2);
            }

            return result;
        }
    }
}

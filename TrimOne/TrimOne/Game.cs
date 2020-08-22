using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimOne
{
    class Game
    {
        string initialWord;

        public void Play()
        {
            Console.WriteLine("Please enter the word to be trimmed, at least 3 letters long: ");
            initialWord = Console.ReadLine();

            if (initialWord.Length < 3)
            {
                Console.WriteLine("Need more characters, please!");
                Play();
            }

            else
            {
                Console.WriteLine("Your adjusted word is " + AdjustedWord(initialWord));
                Console.ReadLine();
            }
        }

        private string AdjustedWord(string x)
        {
            string result = x.Substring(1, initialWord.Length-2);
            return result;
        }

    }
}

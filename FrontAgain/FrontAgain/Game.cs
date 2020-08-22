using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontAgain
{
    class Game
    {
        string word;
        string firstTwo;
        string lastTwo;
        bool Comparison;

        public void Play()
        {
            Console.WriteLine("\nPlease enter the word you wish me to evaluate (Minimum 4 characters: ");
            word = Console.ReadLine();

            if (word.Length < 4)
            {
                Console.WriteLine("\nDUMBASS!!! YOU NEED AT LEAST 4 CHARACTERS!! 4!!!! ");
                Play();
            }

            else
            {
                Comparison = TrueOrFalse(word);
                DisplayResult();
            }
        }

        private bool TrueOrFalse(string x)
        {
            firstTwo = x.Substring(0, 2);
            lastTwo = x.Substring((word.Length - 2), 2);

            if (firstTwo == lastTwo)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private void DisplayResult()
        {
            if (Comparison == true)
            {
                Console.WriteLine("\nYup, the first two letters match the last two letters in the word {0}.", word);
                Play();
            }

            else
            {
                Console.WriteLine("\nSorry, the opening two characters in the word {0} do not match the last two.", word);
                Play();
            }
        }
    }
}

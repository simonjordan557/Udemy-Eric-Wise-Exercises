using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fRONTaNDbACK
{
    class Game
    {
        string word;
        string nString;
        int n;
        string front;
        string back;
        string combined;

        public void Play()
        {
            Console.WriteLine("\nPlease enter the word you wish to be doctored: ");
            word = Console.ReadLine();

            if (word == "")
            {
                Console.WriteLine("\nYou didn't enter a word, dipshit. Try again. ");
                Play();
            }

            Console.WriteLine("\nPlease enter the number of characters to be used from each end: ");
            nString = Console.ReadLine();
            n = int.Parse(nString);

            if (n > word.Length)
            {
                Console.WriteLine("\nSPAZ!!! THERE AREN'T THAT MANY CHARACTERS IN THE WORD!!");
                Play();
            }

            else
            {
                combined = Rearrange(word, n);
                Console.WriteLine("\nThe result is: {0}.", combined);
                Console.ReadLine();
            }

        }

        private string Rearrange(string x, int y)
        {
            front = word.Substring(0, y);
            back = word.Substring((word.Length - y), y);
            combined = front + back;
            return combined;
        }
    }
}

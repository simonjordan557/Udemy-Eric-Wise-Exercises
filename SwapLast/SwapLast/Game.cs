using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapLast
{
    class Game
    {
        string word;
        string result;
        string reversed;
        string firsthalf;

        public void Play()
        {
            Console.WriteLine("\nPlease enter the word which you would like to doctor (2 characters minimum, obviously): ");
            word = Console.ReadLine();

            if (word.Length < 2)
            {
                Console.WriteLine("\nI SAID AT LEAST 2 CHARACTERS, BITCH!");
                Play();
            }

            else
            {
                result = Rearrange(word);
                Console.WriteLine("\nThe result is: {0}!", result);
                Console.ReadLine();
            }
        }

        private string Rearrange(string x)
        {
            reversed = x.Substring((x.Length - 1), 1) + x.Substring((x.Length - 2), 1);
            firsthalf = x.Substring(0, (x.Length - 2));
            result = firsthalf + reversed;
            return result;
        }
    }
}

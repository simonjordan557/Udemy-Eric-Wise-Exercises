using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateLeft2
{
    class Game
    {
        string word;
        string firstTwo;
        string remainder;
        string result;

        public void Play()
        {
            Console.WriteLine("Please enter a word of at least 2 characters: ");
            word = Console.ReadLine();

            if (word.Length < 2)
            {
                Console.WriteLine("\nDUMBASS! I SAID AT LEAST TWO CHARACTERS LONG!!!");
                Play();
            }

            else
            {
                result = Rearrange(word);
                Console.WriteLine("\nYour new word is: {0}", result);
                Console.ReadLine();
            }
        }

        private string Rearrange(string x)
        {
            firstTwo = x.Substring(0, 2);
            remainder = x.Substring(2, (word.Length - 2));
            result = remainder + firstTwo;
            return result;

        }
    }
}

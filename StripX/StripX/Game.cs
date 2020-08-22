using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripX
{
    class Game
    {
        string word;
        string first;
        string last;
        string middle;
        string result;

        public void Play()
        {
            Console.WriteLine("\nEnter the word to be formatted: ");
            word = Console.ReadLine().ToUpper();

            first = word.Substring(0, 1);
            last = word.Substring((word.Length - 1), 1);
            middle = word.Substring(1, (word.Length - 2));

            if (first == "X")
            {
                first = "";
            }

            if (last == "X")
            {
                last = "";
            }

            result = first + middle + last;
            Console.WriteLine("\nYour result is: {0}.", result);
            Play();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweakFront
{
    class Game
    {
        string word;
        string first;
        string second;
        string remainder;
        string result;

        public void Play()
        {
            Console.WriteLine("\nEnter the word to be doctored: ");
            word = Console.ReadLine().ToUpper();

            first = word.Substring(0, 1);
            second = word.Substring(1, 1);
            remainder = word.Substring(2, (word.Length - 2));

            if (first != "A")
            {
                first = "";
            }

            else if (first == "A")
            {
                first = "A";
            }
            
            if (second != "B")
            {
                second = "";
            }

            else if (second == "B")
            {
                second = "B";
            }

            result = first + second + remainder;
            Console.WriteLine("\nYour result is: {0}!", result);
            Play();
        }
    }
}

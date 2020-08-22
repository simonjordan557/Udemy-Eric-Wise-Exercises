using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinCat
{
    class Game
    {
        string wordA;
        string wordB;
        string result;

        public void Play()
        {
            Console.WriteLine("\nPlease enter word 1: ");
            wordA = Console.ReadLine();

            Console.WriteLine("\nPlease enter word 2: ");
            wordB = Console.ReadLine();

            if (wordA.Length == wordB.Length)
            {
                Console.WriteLine("\nyour new word is: " + wordA + wordB + ".");
            }

            else if (wordA.Length > wordB.Length)
            {
                wordA = wordA.Substring((wordA.Length - wordB.Length), wordB.Length);
                result = wordA + wordB;
                Console.WriteLine("\nYour new word is: {0}", result);
            }

            else if (wordB.Length > wordA.Length)
            {
                wordB = wordB.Substring((wordB.Length - wordA.Length), wordA.Length);
                result = wordA + wordB;
                Console.WriteLine("\nYour new word is: {0}", result);
            }

            Play();

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConCat
{
    class Game
    {
        string wordA;
        string wordB;
        string result;

        public void Play()
        {
            Console.WriteLine("\nEnter the first word to be combined: ");
            wordA = Console.ReadLine();

            Console.WriteLine("\nEnter the second word to be combined: ");
            wordB = Console.ReadLine();

            if (wordA[(wordA.Length - 1)] == wordB[0])
            {
                wordB = wordB.Substring(1, (wordB.Length - 1));
            }

            result = wordA + wordB;
            Console.WriteLine("\nThe result is: {0}!", result);
            Console.ReadLine();
        }

    }
}

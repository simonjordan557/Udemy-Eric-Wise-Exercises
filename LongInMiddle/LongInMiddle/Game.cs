using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongInMiddle
{
    class Game
    {
        string stringA;
        string stringB;
        string longer;
        string shorter;

        public void Play()
        {
            Console.WriteLine("Please enter the first word: ");
            stringA = Console.ReadLine();

            Console.WriteLine("Please enter a second word of different length: ");
            stringB = Console.ReadLine();

            if (stringA.Length == stringB.Length)
            
            {
                Console.WriteLine("I SAID DIFFERENT LENGTH WORDS!!!! TRY AGAIN!!");
                Play();
            }

            else if (stringA.Length > stringB.Length)
            {
                longer = stringA;
                shorter = stringB;
            }

            else if (stringA.Length < stringB.Length)
            {
                longer = stringB;
                shorter = stringA;
            }

            Console.WriteLine("Your new word-thing is: {0}{1}{0}", shorter, longer, shorter);

            Console.ReadLine();
        }

    }
}

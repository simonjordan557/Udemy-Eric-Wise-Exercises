using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasBad
{
    class Game
    {
        string word;
        string index0;
        string index1;

        public void Play()
        {
            Console.WriteLine("\nPlease enter the word to be tested: ");
            word = Console.ReadLine();

            bool BadOrNo = TestWord(word);

            if (BadOrNo == true)
            {
                Console.WriteLine("\nThe word {0} contains 'bad' in the correct position. ", word);
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("\nThe word {0} does not contain 'bad' in the correct position, or at all.", word);
                Console.ReadLine();
            }
        }

        private bool TestWord(string x)
        {
            if (x.Length == 3)
            {
                index0 = x.Substring(0, 3);
            }

            if (x.Length >= 4)
            {
                index1 = x.Substring(1, 3);
                index0 = x.Substring(0, 3);
            }

            else if (x.Length <=2)
            {
                return false;
            }

            if (index0 == "BAD")
            {
                return true;
            }

            else if (index1 == "BAD")
            {
                return true;
            }

            else if (index0 == "bad")
            {
                return true;
            }

            else if (index1 == "bad")
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndsWithLy
{
    class Game
    {
        string word;
        bool LyOrNot;
        string lastTwo;

        

        public void Play()
        {
            Console.WriteLine("\nPlease enter the word you wish me to test (MINIMUM 2 CHARACTERS): ");
            word = Console.ReadLine();

            if (word.Length < 2)
            {
                Console.WriteLine("\nI SAID AT LEAST TWO CHARACTERS, BITCH!!!!!");
                Play();
            }

            else
            {
               LyOrNot = Rearrange(word);
               
                if (LyOrNot == true)
                {
                    Console.WriteLine("\nThat passes the test! It ends in 'ly'!");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("\nThat word DOES NOT end in 'ly'. ");
                    Console.ReadLine();
                }
            }
        }

        private bool Rearrange(string x)
        {
            lastTwo = x.Substring((x.Length - 2), 2);

            if (lastTwo == "ly")
            {
                return true;
            }

            else if (lastTwo == "LY")
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

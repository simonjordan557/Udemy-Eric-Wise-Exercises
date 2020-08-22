using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeOne
{
    class Game
    {
        string word;
        string result;
        string boolReturn;

        public void Play()
        {
            Console.WriteLine("Please enter the word which you need to adjust (Minimum 1 character): ");
            word = Console.ReadLine();

            if (word.Length < 1)
            {
                Console.WriteLine("\nI SAID MINIMUM 1 CHARACTER, DUMBASS!!!!");
                Play();
            }

            else
            {
                FindFirstOrLast();
            }
        }

        private void FindFirstOrLast()
        {
                Console.WriteLine("\nDo you want to print the first or last letter of {0}? (ENTER 'F' or 'L'): ", word);
                boolReturn = Console.ReadLine();


                if (boolReturn == "F")
                {
                    result = Rearrange(word);
                    Console.WriteLine("\nYour result is: {0}", result);
                    Console.ReadLine();
                }

                else if (boolReturn == "L")
                {
                    result = Rearrange(word);
                    Console.WriteLine("\nYour result is: {0}", result);
                    Console.ReadLine();
                }

                else
                {
                Console.WriteLine("INVALID INPUT, DUMBASS!!!!");
                FindFirstOrLast();
                }
        }

        private string Rearrange(string x)
        {
            if (boolReturn == "F")
            {
                string answer = x.Substring(0, 1);
                return answer;
            }

            else
            {
                string answer = x.Substring((x.Length - 1), 1);
                return answer;
            }
        } 
    }
}


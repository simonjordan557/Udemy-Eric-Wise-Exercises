using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random target = new Random();
            int playerguess;
            string playerinput;
            int answer;
            answer = target.Next(1, 21);
            bool isnumberguessed = false;
            int guesscount = 0;

            Console.Write("Guess what number I'm thinking of, between 1 and 20: ");

            do
            {
                playerinput = Console.ReadLine();
                playerguess = int.Parse(playerinput);

                if ((playerguess <= 0) || (playerguess >= 21))
                {
                    Console.WriteLine("I SAID BETWEEN 1 AND 20, NUMBNUTS!!! Try again.");
                    guesscount++;
                }
                else
                {
                    if (playerguess < answer)
                    {
                        Console.WriteLine("Too low! Guess again!");
                        guesscount++;
                    }
                    else if (playerguess > answer)
                    {
                        Console.WriteLine("Too high! Guess again!");
                        guesscount++;
                    }
                    else
                    {
                        Console.WriteLine("Correct!!");
                        guesscount++;
                        Console.WriteLine("You won the game using {0} guesses.", guesscount);
                        Console.WriteLine("======================================================");
                        isnumberguessed = true;
                    }
                }
            }
            while (isnumberguessed == false);

            Console.ReadLine();
        }
    }
}

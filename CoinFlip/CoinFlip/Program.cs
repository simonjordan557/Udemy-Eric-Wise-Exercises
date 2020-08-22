using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin;
            string coindescription;
            string userguess;
            Random rng = new Random();

            //Query the user

            Console.Write("Enter your guess, Heads or Tails (H or T)");
            userguess = Console.ReadLine();

            //Get a random number to determine coin outcome

            coin = rng.Next(2);

            if (coin == 0)
            {
                coindescription = "Tails";
            }
            else
            {
                coindescription = "Heads";
            }


            if ((coin == 0 && userguess == "T") || (coin == 1 && userguess == "H"))
            {
                Console.WriteLine("The coin flip was " + coindescription + ", you win!");
            }
            else
            {
                Console.WriteLine("The coin flip was " + coindescription + ", you lose!");
            }
            Console.ReadLine();
        }
    }
}

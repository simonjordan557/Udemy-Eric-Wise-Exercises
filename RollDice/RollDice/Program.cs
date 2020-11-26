using System;
using RollDiceLibrary;

namespace RollDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();
            Random rng = new Random();
            int die1 = rng.Next(1, 7);
            int die2 = rng.Next(1, 7);
            bool noDoubles = rng.Next(0, 2) == 0 ? true : false;
            string noDoublesString = noDoubles ? "are not" : "are";

            Console.WriteLine($"rolling a {die1} and a {die2} gives a total of {evaluator.RollDice(die1, die2, noDoubles)}, if doubles {noDoublesString} allowed.");
        }
    }
}

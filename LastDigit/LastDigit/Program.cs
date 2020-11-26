using System;
using LastDigitLibrary;

namespace LastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();
            Random rng = new Random();
            int a = rng.Next(0, 100);
            int b = rng.Next(0, 100);
            int c = rng.Next(0, 100);
            string resultString = evaluator.LastDigit(a, b, c) ? "do" : "do not";
            Console.WriteLine($"At least two of the following numbers: {a}, {b}, {c} {resultString} have the same last digit.");
        }
    }
}

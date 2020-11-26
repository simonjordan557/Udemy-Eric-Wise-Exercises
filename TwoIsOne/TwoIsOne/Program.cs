using System;
using TwoIsOneLibrary;

namespace TwoIsOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();
            Random rng = new Random();
            int a = rng.Next(1, 10);
            int b = rng.Next(1, 10);
            int c = rng.Next(1, 10);
            string resultString = evaluator.TwoIsOne(a, b, c) ? "can" : "can not";

            Console.WriteLine($"Two of the numbers {a}, {b}, {c} {resultString} be added together to make the third.");
        }
    }
}

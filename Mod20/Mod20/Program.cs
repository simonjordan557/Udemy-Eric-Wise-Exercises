using System;
using Mod20Library;

namespace Mod20
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();
            Random rng = new Random();
            int n = rng.Next(1, 1000);
            string result = evaluator.Mod20(n) ? "" : "not";
            Console.WriteLine($"{n} is {result} 1 or 2 more than a multiple of 20.");
        }
    }
}

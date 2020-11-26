using System;
using Mod35Library;

namespace Mod35
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();
            Random rng = new Random();
            int n = rng.Next(1, 1000);
            string result = evaluator.Mod35(n) ? "is" : "is not";
            Console.WriteLine($"{n} {result} divisible by 3 OR 5 but not both.");
        }
    }
}

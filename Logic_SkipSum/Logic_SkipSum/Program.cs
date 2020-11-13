using System;
using Logic_SkipSumLibrary;

namespace Logic_SkipSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();
            Random rng = new Random();
            int a = rng.Next(1, 16);
            int b = rng.Next(1, 16);
            Console.WriteLine($"a = {a}, b = {b}, result is {evaluator.Go(a, b)}.");
        }
    }
}

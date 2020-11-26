using System;

using SumDoubleLibrary;

namespace SumDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();
            Random rng = new Random();
            int a = rng.Next(1, 10);
            int b = rng.Next(1, 10);
            Console.WriteLine($"{a} SumDouble {b} equals {evaluator.SumDouble(a, b)}.");
        }
    }
}

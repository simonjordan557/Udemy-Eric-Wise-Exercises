using System;
using SpecialElevenLibrary;

namespace SpecialEleven
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();
            Random rng = new Random();
            int n = rng.Next(1, 1000);
            string result = evaluator.SpecialEleven(n) ? "is special" : "is not special";
            Console.WriteLine($"The number {n} {result}.");
        }
    }
}

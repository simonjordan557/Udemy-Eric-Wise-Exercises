using System;
using PlayOutsideLibrary;

namespace PlayOutside
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();
            Random rng = new Random();
            int temp = rng.Next(45, 120);
            bool isSummer = (rng.Next(0, 2) == 0);
            Console.WriteLine($"Temperature is {temp}. Is it Summer? {isSummer}. Can the kids play outside? {evaluator.Go(temp, isSummer)}.");
        }
    }
}

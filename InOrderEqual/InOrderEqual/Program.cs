using System;
using InOrderEqualLibrary;

namespace InOrderEqual
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
            bool equalOK = rng.Next(0, 2) == 0 ? true : false;
            string equalOKString = equalOK ? "is" : "is not";
            string resultString = evaluator.InOrderEqual(a, b, c, equalOK) ? "are" : "are not";
            Console.WriteLine($"The numbers {a}, {b}, {c} {resultString} in order. (Equality {equalOKString} allowed).");


        }
    }
}

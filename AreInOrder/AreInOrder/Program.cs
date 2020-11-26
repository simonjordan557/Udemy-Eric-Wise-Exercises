using System;

using AreInOrderLibrary;

namespace AreInOrder
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
            bool bOK = rng.Next(0, 2) == 0 ? true : false;
            string bOKString = bOK ? "is not" : "is";
            string resultString = evaluator.AreInOrder(a, b, c, bOK) ? "are" : "are not";

            Console.WriteLine($"The numbers {a}, {b}, {c} {resultString} in order, if {b} being greater than {a} {bOKString} important.");
        }
    }
}

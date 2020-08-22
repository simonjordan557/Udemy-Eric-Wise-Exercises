using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();

            Console.WriteLine($"\nResult of 1 + 2 + 3 is: {evaluator.Sum(1, 2, 3)}.\n");
            Console.WriteLine($"\nResult of 5 + 11 + 2 is: {evaluator.Sum(5, 11, 2)}.\n");
            Console.WriteLine($"\nResult of 7 + 0 + 0 is: {evaluator.Sum(7, 0, 0)}.\n");

            Console.ReadLine();
        }
    }
}

using System;
using System.Text.RegularExpressions;
using Fix23Library;

namespace Fix23
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();
            Random rng = new Random();

            Console.WriteLine("GENERATING A RANDOM ARRAY OF 10 INTEGERS, 1 - 5: \n");

            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = rng.Next(1, 5);
            }

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("\n\nRESULTS: \n");

            int[] results = evaluator.Fix23(numbers);

            foreach (int res in results)
            {
                Console.Write($"{res} ");
            }
            Console.ReadLine();
        }
    }
}

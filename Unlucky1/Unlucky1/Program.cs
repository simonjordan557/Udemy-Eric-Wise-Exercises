using System;
using Unlucky1Library;

namespace Unlucky1
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();
            Random rng = new Random();
            int[] randomArray = new int[6];

            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rng.Next(1, 7);
            }

            foreach (int i in randomArray)
            {
                Console.Write($"{i} ");
            }
            Console.Write($"  =>  {evaluator.Go(randomArray)}\n\n");
        }
    }
}

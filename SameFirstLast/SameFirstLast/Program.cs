using System;

namespace SameFirstLast
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayOne = new int[] { 1, 2, 3 };
            int[] arrayTwo = new int[] { 1, 2, 3, 1 };
            int[] arrayThree = new int[] { 1, 2, 1 };
            int[] failTest = new int[0];

            Evaluator evaluator = new Evaluator();
            Console.WriteLine($"ArrayOne: {evaluator.SameFirstLast(arrayOne)}.");
            Console.WriteLine($"ArrayTwo: {evaluator.SameFirstLast(arrayTwo)}.");
            Console.WriteLine($"ArrayThree: {evaluator.SameFirstLast(arrayThree)}.");
            Console.WriteLine($"FailTest: {evaluator.SameFirstLast(failTest)}.");

            Console.ReadLine();
        }
    }
}

using System;

namespace FirstLast6
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();

            int[] arrayOne = new int[] { 1, 2, 6 };
            int[] arrayTwo = new int[] { 6, 1, 2, 3 };
            int[] arrayThree = new int[] { 13, 6, 1, 2, 3 };
            int[] failTest = new int[0];

            Console.WriteLine($"ArrayOne: {evaluator.FirstLast6(arrayOne)}.");
            Console.WriteLine($"ArrayTwo: {evaluator.FirstLast6(arrayTwo)}.");
            Console.WriteLine($"ArrayThree: {evaluator.FirstLast6(arrayThree)}.");
            Console.WriteLine($"FailTest: {evaluator.FirstLast6(failTest)}.");

            Console.ReadLine();

        }
    }
}

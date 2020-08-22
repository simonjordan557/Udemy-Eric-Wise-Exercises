using System;

namespace CommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();

            int[] arrayTest = new int[] { 1, 2, 3 };
            int[] arrayOne = new int[] { 7, 3 };
            int[] arrayTwo = new int[] { 7, 3, 2 };
            int[] arrayThree = new int[] { 1, 3 };
            int[] failTest = new int[0];

            Console.WriteLine($"\nArrayOne: {evaluator.CommonEnd(arrayTest, arrayOne)}.\n");
            Console.WriteLine($"\nArrayTwo: {evaluator.CommonEnd(arrayTest, arrayTwo)}.\n");
            Console.WriteLine($"\nArrayThree: {evaluator.CommonEnd(arrayTest, arrayThree)}.\n");
            Console.WriteLine($"\nFailTest: {evaluator.CommonEnd(arrayTest, failTest)}.\n");

            Console.ReadLine();


           
        }
    }
}

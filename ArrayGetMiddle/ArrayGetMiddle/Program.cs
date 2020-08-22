using System;

namespace ArrayGetMiddle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n\t****\tUNIT TEST STARTING\t****\t\n");

            UnitTest test = new UnitTest();

            int[] testArrayOne = new int[3] { 1, 2, 3 };
            int[] testArrayTwo = new int[3] { 4, 5, 6 };
            int[] testArrayExpectedResult = new int[2] { 2, 5 };

            test.Test(testArrayOne, testArrayTwo, testArrayExpectedResult);

            Console.WriteLine("\n\t****\tUNIT TESTING COMPLETE\t****\t\n");

            int a, b, c, d, e, f;

            Evaluator evaluator = new Evaluator();
       

            Console.WriteLine("\nGive me 3 nunmbers for first array!\n");
   
            a = evaluator.GetAndValidateInt();
            b = evaluator.GetAndValidateInt();
            c = evaluator.GetAndValidateInt();

            Console.WriteLine("\nGive me 3 nunmbers for second array!\n");

            d = evaluator.GetAndValidateInt();
            e = evaluator.GetAndValidateInt();
            f = evaluator.GetAndValidateInt();

            int[] arrayOne = new int[3] { a, b, c };
            int[] arrayTwo = new int[3] { d, e, f };

            int[] returnedArray = evaluator.ArrayGetMiddle(arrayOne, arrayTwo);

            string returnedString = evaluator.IntArrayToString(returnedArray);

            Console.WriteLine($"\nThe array created from middle values is: {returnedString}.\n");

            Console.ReadLine();

        }

       
    }
}

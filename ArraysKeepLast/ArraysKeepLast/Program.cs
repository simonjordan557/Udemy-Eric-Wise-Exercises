using System;

namespace ArraysKeepLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start unit test
            UnitTest test = new UnitTest();

            int[] testArrayOne = new int[3] { 4, 5, 6 };
            int[] testArrayTwo = new int[2] { 1, 2 };
            int[] testArrayThree = new int[1] { 3 };

            int[][] testBed = new int[3][] { testArrayOne, testArrayTwo, testArrayThree };

            int[] expectedReturnArrayOne = new int[6] { 0, 0, 0, 0, 0, 6 };
            int[] expectedReturnArrayTwo = new int[4] { 0, 0, 0, 2 };
            int[] expectedReturnArrayThree = new int[2] { 0, 3 };

            int[][] expectedReturnBed = new int[3][] { expectedReturnArrayOne, expectedReturnArrayTwo, expectedReturnArrayThree }; 



            Console.WriteLine("\n\t****\tUNIT TEST STARTING\t****\t\n");


            for (int i = 0; i < testBed.Length; i++)
            {
                Console.WriteLine($"\n\t****\tTEST PASSED?\t****\t{test.Test(testBed[i], expectedReturnBed[i]).ToString().ToUpper()}!\t****\t\n");
            }

            Console.WriteLine("\n\t****\tUNIT TEST COMPLETE\t****\t\n");





            //Start program
            Evaluator evaluator = new Evaluator();

            int[] numbers = evaluator.BuildArrayFromUserInput();

            int[] returnedArray = evaluator.ArraysKeepLast(numbers);

            string returnedString = evaluator.IntArrayToString(returnedArray);

            Console.WriteLine($"\n\tTHE RESULT IS: {returnedString}.\n");

            Console.ReadLine();



        }
    }
}

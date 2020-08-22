using System;
using System.Collections.Generic;

namespace ArrayHasEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //Run unit test 
            UnitTest test = new UnitTest();

            Console.WriteLine("\n\t****\tUNIT TEST STARTING\t****\t\n");

            int[] testArrayOne = new int[2] { 2, 5 };
            int[] testArrayTwo = new int[2] { 4, 3 };
            int[] testArrayThree = new int[2] { 7, 5 };
            int[] testArrayFour = new int[5] { 1, 3, 5, 7, 9 };


            test.Test(testArrayOne, true);
            test.Test(testArrayTwo, true);
            test.Test(testArrayThree, false);
            test.Test(testArrayFour, false);

            Console.WriteLine("\n\t****\tUNIT TEST COMPLETE\t****\t\n");



            //Start method
            Evaluator evaluator = new Evaluator();

            Console.WriteLine("\nHow many numbers in your array?");

            int arrayLength = evaluator.GetAndValidateInt();

            List<int> arrayList = new List<int>();

            Console.WriteLine("\nEnter your array elements, one at a time.\n");

            for (int i = 0; i < arrayLength; i++)
            {
                arrayList.Add(evaluator.GetAndValidateInt());
            }

            int[] numbers = arrayList.ToArray();

            bool returnedBool = evaluator.ArrayHasEven(numbers);
            
            if (returnedBool)
            {
                Console.WriteLine("\nThe sequence ");

                foreach (var item in arrayList)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine("DOES contain even numbers.\n");

            }

            else
            {
                Console.WriteLine("\nThe sequence ");

                foreach (var item in arrayList)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine("DOES NOT contain even numbers.\n");
            }

            Console.ReadLine();

        }
    }
}

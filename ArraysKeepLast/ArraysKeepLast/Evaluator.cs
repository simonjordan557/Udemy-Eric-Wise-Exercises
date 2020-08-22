using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysKeepLast
{
    class Evaluator
    {
        public int[] ArraysKeepLast(params int[] numbers)
        {
            int returnLength = numbers.Length * 2;
            int[] returnedArray = new int[returnLength];

            returnedArray[returnLength - 1] = numbers[numbers.Length - 1];

            return returnedArray;

        }

        public int[] BuildArrayFromUserInput()
        {
            Console.WriteLine("\nHow many numbers in your array?");

            int arrayLength = GetAndValidateInt();

            List<int> arrayList = new List<int>();

            Console.WriteLine("\nEnter your array elements, one at a time.\n");

            for (int i = 0; i < arrayLength; i++)
            {
                arrayList.Add(GetAndValidateInt());
            }

            int[] numbers = arrayList.ToArray();

            return numbers;
        }

        public int GetAndValidateInt()

        {

            bool validInt;
            int validatedInt;


            while (true)
            {
                Console.WriteLine("\nEnter your number:");

                string input = Console.ReadLine();

                validInt = int.TryParse(input, out validatedInt);

                if (!validInt || validatedInt < 1)
                {
                    Console.WriteLine($"\n{input} is not a valid response.");
                }

                else
                {
                    return validatedInt;
                }

            }
        }


        public string IntArrayToString(int[] inputArray)
        {
            string returnString = "";

            for (int i = 0; i < inputArray.Length; i++)
            {
                returnString += inputArray[i].ToString();

                if (i != inputArray.Length - 1)
                {
                    returnString += ", ";
                }
            }

            return returnString;
        }
    }
}

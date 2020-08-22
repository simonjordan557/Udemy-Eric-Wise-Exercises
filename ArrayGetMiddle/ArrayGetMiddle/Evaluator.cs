using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayGetMiddle
{
    class Evaluator
    {

        public int[] ArrayGetMiddle(int[] a, int[] b)
        {
            int[] returnedArray = new int[2];

            returnedArray[0] = a[1];
            returnedArray[1] = b[1];

            return returnedArray;
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

                if (!validInt)
                {
                    Console.WriteLine($"\n{input} is not a valid response.");
                    GetAndValidateInt();
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

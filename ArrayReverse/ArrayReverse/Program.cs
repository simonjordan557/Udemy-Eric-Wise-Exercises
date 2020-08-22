using System;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();

            int[] returnedArray = evaluator.ArrayReverse(1, 2, 3);

            string resultString = IntArrayToString(returnedArray);

            Console.WriteLine($"\nreversing array containing 1, 2, 3: Result is {resultString}.\n");



        }


        public static string IntArrayToString(int[] inputArray)
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

using System;

namespace ArrayHigherWins
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();

            int[] returnedArrayOne = evaluator.ArrayHigherWins(1, 2, 3);
            int[] returnedArrayTwo = evaluator.ArrayHigherWins(11, 5, 9);
            int[] returnedArrayThree = evaluator.ArrayHigherWins(2, 11, 3);

            string stringArrayOne = IntArrayToString(returnedArrayOne);
            string stringArrayTwo = IntArrayToString(returnedArrayTwo);
            string stringArrayThree = IntArrayToString(returnedArrayThree);

            Console.WriteLine($"\nProviding numbers 1, 2, 3 returns: {stringArrayOne}.\n");
            Console.WriteLine($"\nProviding numbers 11, 5, 9 returns: {stringArrayTwo}.\n");
            Console.WriteLine($"\nProviding numbers 2, 11, 3 returns: {stringArrayThree}.\n");

            Console.ReadLine();

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

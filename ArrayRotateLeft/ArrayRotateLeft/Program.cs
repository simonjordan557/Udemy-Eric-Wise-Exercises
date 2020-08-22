using System;
using System.Security.Cryptography.X509Certificates;

namespace ArrayRotateLeft
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();

            int[] returnedArrayOne = evaluator.ArrayRotateLeft(1, 2, 3);
            int[] returnedArrayTwo = evaluator.ArrayRotateLeft(5, 11, 9);
            int[] returnedArrayThree = evaluator.ArrayRotateLeft(7, 0, 0);

            string returnedStringOne = intArrayToString(returnedArrayOne);
            string returnedStringTwo = intArrayToString(returnedArrayTwo);
            string returnedStringThree = intArrayToString(returnedArrayThree);

            Console.WriteLine($"\nSending 1, 2, 3 returns: {returnedStringOne}.\n");
            Console.WriteLine($"\nSending 5, 11, 9 returns: {returnedStringTwo}.\n");
            Console.WriteLine($"\nSending 7, 0, 0 returns: {returnedStringThree}.\n");

            Console.ReadLine();







        }

        public static string intArrayToString(int[] inputArray)
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

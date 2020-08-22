using System;
using System.Globalization;

namespace MakePi
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();
            int digits = 0;
            bool legitInput = false;
            int[] returnedArray;
            

            Console.WriteLine("\nHow many digits of Pi do you need?");

            while (!legitInput || digits <= 0)
            {
                Console.WriteLine("\nPlease enter a valid positive number.\n");

                legitInput = int.TryParse(Console.ReadLine(), out digits);

            }

            returnedArray = evaluator.MakePi(digits);

            Console.Write($"\nPi to {digits} digits is: {returnedArray[0]}.");

            for (int j = 1; j < returnedArray.Length; j++)
            {
                Console.Write(returnedArray[j]);
            }

            Console.Write($".");


        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayHasEven
{
    class Evaluator
    {
        public bool ArrayHasEven(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    return true;
                }

                
            }

            return false;
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
    }
}

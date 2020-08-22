using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayRotateLeft
{
    class Evaluator
    {
        public int[] ArrayRotateLeft(params int[] numbers)
        {
            int[] returnedArray = new int[numbers.Length];

            for (int i = 1; i < numbers.Length; i++)
            {
                returnedArray[i - 1] = numbers[i];
            }

            returnedArray[numbers.Length - 1] = numbers[0];

            return returnedArray;
        }
    }
}

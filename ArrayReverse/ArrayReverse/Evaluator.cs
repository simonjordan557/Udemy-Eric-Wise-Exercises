using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayReverse
{
    class Evaluator
    {
        public int[] ArrayReverse(params int[] numbers)
        {


            List<int> returnedList = new List<int>();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                returnedList.Add(numbers[i]);
            }

            int[] returnedArray = returnedList.ToArray();

            return returnedArray;
        }
    }
}

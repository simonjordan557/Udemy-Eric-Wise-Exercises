using System;
using System.Collections.Generic;
using System.Text;

namespace SameFirstLast
{
    class Evaluator
    {
        public bool SameFirstLast(int[] numbers)
        {
            if (numbers.Length < 1)
            {
                Console.WriteLine("\nArray cannot be empty!");
                return false;
            }

            else if (numbers[0] == numbers[numbers.Length - 1])
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayHigherWins
{
    class Evaluator
    {
        public int[] ArrayHigherWins(params int[] numbers)
        {
            int first = numbers[0];
            int last = numbers[numbers.Length - 1];

            if (first > last)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = first;
                }

                return numbers;
            }

            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = last;
                }

                return numbers;
            }


            

            
        }
    }
}

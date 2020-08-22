using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLast6
{
    class Evaluator
    {
        public bool FirstLast6(int[] numbers)
        {

            if (numbers.Length < 1)
            {
                Console.WriteLine("You cannot enter an empty array.");
                return false;

            }



            else if ((numbers[0] == 6) || (numbers[numbers.Length - 1] == 6))
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

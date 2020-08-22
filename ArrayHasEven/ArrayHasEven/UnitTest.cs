using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayHasEven
{
    class UnitTest
    {
        public bool Test(int[] numbers, bool expectedResult)
        {
            Evaluator testEvaluator = new Evaluator();

            bool returnedFromFunction = testEvaluator.ArrayHasEven(numbers);

            if (returnedFromFunction.Equals(expectedResult))
            {
                Console.WriteLine("\n\t****\tTEST WAS SUCCESFUL\t****\t\n");
                return true;
            }

            else
            {
                Console.WriteLine("\n\t****\tTEST FAILED\t****\t\n");
                return false;
            }
        }
    }
}

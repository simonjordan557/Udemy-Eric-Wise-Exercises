using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayGetMiddle
{
    class UnitTest
    {
        public bool Test(int[] a, int[] b, int[] expectedResult)
        {
            Evaluator testEvaluator = new Evaluator();

            int[] result = testEvaluator.ArrayGetMiddle(a, b);

            if (result.SequenceEqual(expectedResult))
            {
                Console.WriteLine("\nUNIT TEST PASSED.\n");
                return true;
            }

            else
            {
                Console.WriteLine("\nUNIT TEST FAILED.\n");
                return false;
            }
        }
    }
}

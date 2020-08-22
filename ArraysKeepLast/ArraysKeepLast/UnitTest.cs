using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraysKeepLast
{
    class UnitTest
    {
        public bool Test(int[] a, int[] expectedResult)
        {
            Evaluator testEvaluator = new Evaluator();

            if (testEvaluator.ArraysKeepLast(a).SequenceEqual(expectedResult))
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

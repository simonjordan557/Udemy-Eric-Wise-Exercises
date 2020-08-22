using System;
using System.Collections.Generic;
using System.Text;

namespace Sum
{
    class Evaluator
    {
        
        public int Sum(params int[] a)
        {
            int result = 0;

            for (int i = 0; i < a.Length; i++)
            {
                result += a[i];
            }

            return result;
        }
    }
}

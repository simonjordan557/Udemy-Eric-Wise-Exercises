using System;
using System.Collections.Generic;
using System.Text;

namespace CommonEnd
{
    class Evaluator
    {
        public bool CommonEnd(int[] a, int[] b)
        {
            if (a.Length < 1 || b.Length < 1)
            {
                Console.WriteLine("Arrays cannot be empty.\n");
                return false;
            }

            else if (a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1])
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

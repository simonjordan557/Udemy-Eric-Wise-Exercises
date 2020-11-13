using System;
using System.Linq;

namespace Make2Library
{
    public class Evaluator
    {
        public int[] Go(int[] a, int[] b)
        {
            return a.Concat(b).Take(2).ToArray();
        }
            
    }
}

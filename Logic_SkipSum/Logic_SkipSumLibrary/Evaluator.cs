using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_SkipSumLibrary
{
    public class Evaluator
    {
        public int Go(int a, int b)
        {
            return a + b < 10 || a + b > 19 ? a + b : 20; 
        }
    }
}

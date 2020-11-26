using System;
using System.Collections.Generic;
using System.Text;

namespace SumDoubleLibrary
{
    public class Evaluator
    {
        public int SumDouble(int a, int b)
        {
            return a == b ? (a + b) * 2 : a + b; 
        }
    }
}

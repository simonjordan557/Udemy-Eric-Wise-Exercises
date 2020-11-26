using System;
using System.Collections.Generic;
using System.Text;

namespace TwoIsOneLibrary
{
    public class Evaluator
    {

        public bool TwoIsOne(int a, int b, int c)
        {
            return a + b == c || a + c == b || b + c == a;
        }
    }
}

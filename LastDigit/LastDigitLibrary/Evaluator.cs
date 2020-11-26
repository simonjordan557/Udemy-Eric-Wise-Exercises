using System;
using System.Collections.Generic;
using System.Text;

namespace LastDigitLibrary
{
    public class Evaluator
    {
        public bool LastDigit(int a, int b, int c)
        {
            return Math.Abs(a - b) % 10 == 0 || Math.Abs(a - c) % 10 == 0 || Math.Abs(b - c) % 10 == 0;
        }
    }
}

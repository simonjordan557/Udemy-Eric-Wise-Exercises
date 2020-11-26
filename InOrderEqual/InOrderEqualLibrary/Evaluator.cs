using System;
using System.Collections.Generic;
using System.Text;

namespace InOrderEqualLibrary
{
    public class Evaluator
    {
        public bool InOrderEqual(int a, int b, int c, bool equalOK)
        {
            return equalOK ? c >= b && b >= a : c > b && b > a; 
        }
    }
}

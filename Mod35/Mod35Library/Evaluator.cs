using System;
using System.Collections.Generic;
using System.Text;

namespace Mod35Library
{
    public class Evaluator
    {
        public bool Mod35(int n)
        {
            return (n % 3 == 0 || n % 5 == 0) && !(n % 3 == 0 && n % 5 == 0);
        }
    }
}

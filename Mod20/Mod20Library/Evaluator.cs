using System;
using System.Collections.Generic;
using System.Text;

namespace Mod20Library
{
    public class Evaluator
    {
        public bool Mod20(int n)
        {
            return (n - 1) % 20 == 0 || (n - 2) % 20 == 0;
        }
    }
}

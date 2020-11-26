using System;
using System.Collections.Generic;
using System.Text;

namespace SpecialElevenLibrary
{
    public class Evaluator
    {
        public bool SpecialEleven(int n)
        {
            return (n % 11 == 0 || (n - 1) % 11 == 0);
        }
    }
}

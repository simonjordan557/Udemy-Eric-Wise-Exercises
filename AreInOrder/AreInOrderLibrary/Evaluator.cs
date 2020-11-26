using System;
using System.Collections.Generic;
using System.Text;

namespace AreInOrderLibrary
{
    public class Evaluator
    {
        public bool AreInOrder(int a, int b, int c, bool bOK)
        {
            return (c > b) && (bOK ? true : b > a); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Double23Library
{
   public class Evaluator
    {
        public bool Go(int[] arr)
        {
            return (arr.Count(i => i == 2) == 2) || (arr.Count(i => i == 3) == 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MakePi
{
    class Evaluator
    {
        public int[] MakePi(int digits)
        {
            int[] resultArray = new int[digits];
            string piString = Math.PI.ToString();
            piString = piString.Remove(1, 1);
            piString = piString.Remove(digits);

            for (int i = 0; i < digits; i++)
            {
                resultArray[i] = int.Parse(piString[i].ToString());

            }

            return resultArray;
        }
    }
}

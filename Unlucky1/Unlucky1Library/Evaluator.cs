using System;

namespace Unlucky1Library
{
    public class Evaluator
    {
        public bool Go(int[] numbers)
        {
            int[] indices = new int[] { 0, 1, numbers.Length - 2 };
            foreach (int i in indices)
            {
                if (numbers[i] == 1 && numbers[i + 1] == 3)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

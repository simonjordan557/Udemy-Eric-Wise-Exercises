using System;

namespace PlayOutsideLibrary
{
    public class Evaluator
    {
        public bool Go(int temp, bool isSummer)
        {
            const int lowerTemp = 60;
            int upperTemp = isSummer ? 100 : 90;
            return lowerTemp <= temp && temp <= upperTemp;
        }
    }
}

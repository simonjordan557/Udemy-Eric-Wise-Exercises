using System;
using System.Collections.Generic;
using System.Text;

namespace AreWeInTroubleLibrary
{
    public class Evaluator
    {
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            return (aSmile && bSmile) || (!aSmile && !bSmile);
        }
    }
}

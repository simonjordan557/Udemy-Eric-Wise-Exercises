using System;
using System.Collections.Generic;
using System.Text;

namespace AnswerCellLibrary
{
    public class Evaluator
    {
        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (isAsleep) return false;
            else if (isMorning) return (isMom);
            else return true;
        }
    }
}

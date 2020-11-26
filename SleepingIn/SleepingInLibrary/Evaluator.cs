using System;
using System.Collections.Generic;
using System.Text;

namespace SleepingInLibrary
{
    public class Evaluator
    {
        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            return !isWeekday || isVacation;
        }
    }
}

using System;
using SleepingInLibrary;

namespace SleepingIn
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();
            Random rng = new Random();
            bool isWeekday = rng.Next(0, 2) == 0 ? true : false;
            string isWeekdayString = isWeekday ? "is" : "isn't";
            bool isVacation = rng.Next(0, 2) == 0 ? true : false;
            string isVacationString = isVacation ? "are" : "aren't";
            string resultString = evaluator.CanSleepIn(isWeekday, isVacation) ? "can" : "can't";
            Console.WriteLine($"It {isWeekdayString} a weekday, and you {isVacationString} on vacation. You {resultString} sleep in.");
        }
    }
}

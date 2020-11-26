using System;
using AnswerCellLibrary;

namespace AnswerCell
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();
            Random rng = new Random();

            bool isMorning = rng.Next(0, 2) == 0 ? true : false;
            bool isMom = rng.Next(0, 2) == 0 ? true : false;
            bool isAsleep = rng.Next(0, 2) == 0 ? true : false;
            bool result = evaluator.AnswerCell(isMorning, isMom, isAsleep);
            string resultString = result ? "ANSWER THE PHONE!" : "Don't answer.";

            Console.WriteLine($"Is it morning? {isMorning}.");
            Console.WriteLine($"Is it Mom? {isMom}.");
            Console.WriteLine($"Are you asleep? {isAsleep}.");
            Console.WriteLine($"\n{resultString}");
        }
    }
}

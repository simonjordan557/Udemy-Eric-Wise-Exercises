using System;
using AreWeInTroubleLibrary;

namespace AreWeInTrouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();
            Random rng = new Random();
            bool aSmile = rng.Next(0, 2) == 0 ? true : false;
            string aSmileString = aSmile ? "is" : "is not";
            bool bSmile = rng.Next(0, 2) == 0 ? true : false;
            string bSmileString = bSmile ? "is" : "is not";
            string resultString = evaluator.AreWeInTrouble(aSmile, bSmile) ? "are" : "are not";

            Console.WriteLine($"Child a {aSmileString} smiling. Child b {bSmileString} smiling. We {resultString} in trouble.");
        }
    }
}

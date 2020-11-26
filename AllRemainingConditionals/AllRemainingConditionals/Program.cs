using System;
using AllRemainingConditionalsLibrary;

namespace AllRemainingConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Conditionals conditionals = new Conditionals();
            Random rng = new Random();

            int a, b, c;
            bool z;
            string s;
            string resultString;
            string[] stringArray = new string[] { "Hello", "hi", "hi there,", "I", "am", "not", "a", "list,", "I am", "actually an", "array of strings" };

            // Diff21
            a = rng.Next(1, 41);
            Console.WriteLine($"\n*** Diff21 ***\n");
            Console.WriteLine($"Diff21 of {a} is {conditionals.Diff21(a)}.\n");

            // ParrotTrouble
            a = rng.Next(0, 24);
            z = rng.Next(0, 2) == 0 ? true : false;
            Console.WriteLine($"\n*** ParrotTrouble ***\n");
            Console.WriteLine($"Is parrot talking? {z}.\nIt's {a} o' clock.\nDo we have trouble? {conditionals.ParrotTrouble(z, a)}.\n");

            // Makes10

            a = rng.Next(1, 11);
            b = rng.Next(1, 11);
            resultString = conditionals.Makes10(a, b) ? $"{a} and {b} either add up to 10, or one of them IS 10!\n" : $"neither {a} nor {b} are 10, or add up to 10.\n";
            Console.WriteLine($"\n*** Makes10 ***\n");
            Console.WriteLine(resultString);

            // NearHundred

            a = rng.Next(1, 211);
            resultString = conditionals.NearHundred(a) ? "is" : "isn't";
            Console.WriteLine($"\n*** NearHundred ***\n");
            Console.WriteLine($"{a} {resultString} within 10 of 100 or 200.\n");

            // PosNeg

            a = rng.Next(-10, 11);
            b = rng.Next(-10, 11);
            z = rng.Next(0, 2) == 0 ? true : false;
            Console.WriteLine($"\n*** PosNeg ***\n");
            Console.WriteLine($"a = {a}\nb = {b}\nMust both be negative? {z}.\nPosNeg for {a} and {b} returns {conditionals.PosNeg(a, b, z)}.\n");

            // NotString

            s = stringArray[rng.Next(0, stringArray.Length)];
            Console.WriteLine($"\n*** NotString ***\n");
            Console.WriteLine($"Passing {s} into NotString returns {conditionals.NotString(s)}.");

            // MissingChar

            s = stringArray[rng.Next(0, stringArray.Length)];
            a = rng.Next(0, s.Length);
            Console.WriteLine($"\n*** MissingChar ***\n");
            Console.WriteLine($"When character index {a} is removed from the word \"{s}\", MissingChar returns \"{conditionals.MissingChar(s, a)}\".\n");

            // Front3

            s = stringArray[rng.Next(0, stringArray.Length)];
            Console.WriteLine($"\n*** Front3 ***\n");
            Console.WriteLine($"The word \"{s}\" is transformed into \"{conditionals.Front3(s)}\" by the Front3 method.\n");

            // BackAround

            s = stringArray[rng.Next(0, stringArray.Length)];
            Console.WriteLine($"\n*** BackAround ***\n");
            Console.WriteLine($"The word \"{s}\" is transformed into \"{conditionals.BackAround(s)}\" by the BackAround method.\n");

            // Multiple3or5

            a = rng.Next(1, 1001);
            Console.WriteLine($"\n*** Multiple3or5 ***\n");
            resultString = conditionals.Multiple3or5(a) ? "is" : "isn't";
            Console.WriteLine($"{a} {resultString} a multiple of 3 or 5.\n");

            // StartHi

            s = stringArray[rng.Next(0, stringArray.Length)];
            Console.WriteLine($"\n*** StartHi ***\n");
            resultString = conditionals.StartHi(s) ? "does" : "doesn't";
            Console.WriteLine($"The string \"{s}\" {resultString} start with the word \"hi\".\n");

            // IcyHot

            a = rng.Next(-60, 141);
            b = rng.Next(-60, 141);
            Console.WriteLine($"\n*** IcyHot ***\n");
            Console.WriteLine($"Temperature 1 is {a} degrees.\nTemperature 2 is {b} degrees.\nIcyHot returns {conditionals.IcyHot(a, b)}.\n");

            // Between10and20

            a = rng.Next(0, 100);
            b = rng.Next(0, 100);
            resultString = conditionals.Between10and20(a, b) ? "are" : "aren't";
            Console.WriteLine($"\n*** Between10and20 ***\n");
            Console.WriteLine($"One or both of the numbers {a} and {b} {resultString} between 10 and 20 inclusive.\n");

            // HasTeen

            a = rng.Next(1, 21);
            b = rng.Next(1, 21);
            c = rng.Next(1, 21);
            resultString = conditionals.HasTeen(a, b, c) ? "does" : "doesn't";
            Console.WriteLine($"\n*** HasTeen ***\n");
            Console.WriteLine($"The number set {a}, {b}, and {c} {resultString} contain a number ending in \"teen\".\n");

            // SoAlone
            a = rng.Next(1, 100);
            b = rng.Next(1, 100);
            resultString = conditionals.SoAlone(a, b) ? "is" : "isn't";
            Console.WriteLine($"\n*** SoAlone ***\n");
            Console.WriteLine($"Two people aged {a} and {b}: There {resultString} a teen who is So Alone..\n");
        }
    }
}

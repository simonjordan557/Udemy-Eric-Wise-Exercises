using System;
using AllLoopsLibrary;

namespace AllLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Loops loops = new Loops();
            Random rng = new Random();
            int a, b, c, d, e;
            int[] intArray;
            string s, t;
            string resultString;
            string[] stringArray = new string[] { "This", "is", "an", "array", "of", "strings.", "Exxxtra Strong mints are nice.", "Kayak" };

            // StringTimes

            a = rng.Next(1, 10);
            s = stringArray[rng.Next(0, stringArray.Length)];
            Console.WriteLine($"\n*** StringTimes ***\n");
            Console.WriteLine($"String {s} printed {a} times is {loops.StringTimes(s, a)}.\n");

            // FrontTimes

            a = rng.Next(1, 5);
            s = stringArray[rng.Next(0, stringArray.Length)];
            Console.WriteLine($"\n*** FrontTimes ***\n");
            Console.WriteLine($"First 3 characters of string {s} printed {a} times is {loops.FrontTimes(s, a)}.\n");

            //CountXX

            s = stringArray[rng.Next(0, stringArray.Length)];
            Console.WriteLine($"\n*** CountXX ***\n");
            Console.WriteLine($"String {s} contains {loops.CountXX(s)} \"xx\"s.\n");

            // EveryOther

            s = stringArray[rng.Next(0, stringArray.Length)];
            Console.WriteLine($"\n*** EveryOther ***\n");
            Console.WriteLine($"Every other letter of string {s} returns {loops.EveryOther(s)}.\n");

            // StringSplosion

            s = stringArray[rng.Next(0, stringArray.Length)];
            Console.WriteLine($"\n*** StringSplosion ***\n");
            Console.WriteLine($"String {s}, when StringSploded, returns {loops.StringSplosion(s)}.\n");

            // CountLast2

            s = stringArray[rng.Next(0, stringArray.Length)];
            Console.WriteLine($"\n*** CountLast2 ***\n");
            Console.WriteLine($"String {s} repeats its last two letters ({s.Substring(s.Length - 2, 2)}) {loops.CountLast2(s)} times.\n");

            // Count9

            a = rng.Next(1, 10);
            b = rng.Next(1, 10);
            c = rng.Next(1, 10);
            d = rng.Next(1, 10);
            e = rng.Next(1, 10);
            intArray = new int[] { a, b, c, d, e };
            Console.WriteLine($"\n*** Count9 ***\n");
            Console.WriteLine($"This array: {{{a} {b} {c} {d} {e}}} contains {loops.Count9(intArray)} 9's.\n");

            // ArrayFront9

            a = rng.Next(1, 10);
            b = rng.Next(1, 10);
            c = rng.Next(1, 10);
            d = rng.Next(1, 10);
            e = rng.Next(1, 10);
            intArray = new int[] { a, b, c, d, e };
            resultString = loops.ArrayFront9(intArray) ? "does" : "doesn't";
            Console.WriteLine($"\n*** ArrayFront9 ***\n");
            Console.WriteLine($"This array: {{{a} {b} {c} {d} {e}}} {resultString} have 9 in the first four positions.\n");

            // Array123

            a = rng.Next(1, 5);
            b = rng.Next(1, 5);
            c = rng.Next(1, 5);
            d = rng.Next(1, 5);
            e = rng.Next(1, 5);
            intArray = new int[] { a, b, c, d, e };
            resultString = loops.Array123(intArray) ? "does" : "doesn't";
            Console.WriteLine($"\n*** Array123 ***\n");
            Console.WriteLine($"This array: {{{a} {b} {c} {d} {e}}} {resultString} contain the sequence 1, 2, 3.\n");

            // SubStringMatch

            s = stringArray[rng.Next(0, stringArray.Length)];
            t = stringArray[rng.Next(0, stringArray.Length)];
            Console.WriteLine($"\n*** SubStringMatch ***\n");
            Console.WriteLine($"The strings \"{s}\" and \"{t}\" contain {loops.SubStringMatch(s, t)} matching digraph substrings.\n");

            // StringX

            s = stringArray[rng.Next(0, stringArray.Length)];
            Console.WriteLine($"\n*** StringX ***\n");
            Console.WriteLine($"The string {s} with its internal \"x\"'s stripped away: {loops.StringX(s)}.\n");

            // AltPairs

            s = stringArray[rng.Next(0, stringArray.Length)];
            Console.WriteLine($"\n*** AltPairs ***\n");
            Console.WriteLine($"The string {s} reduced to every other pair of letters: {loops.AltPairs(s)}.\n");

            // DoNotYak

            s = stringArray[rng.Next(0, stringArray.Length)];
            Console.WriteLine($"\n*** DoNotYak ***\n");
            Console.WriteLine($"The string {s} with any occurences of the word \"yak\" removed: {loops.DoNotYak(s)}.\n");

            // Array667

            a = rng.Next(1, 10);
            b = rng.Next(1, 10);
            c = rng.Next(1, 10);
            d = rng.Next(1, 10);
            e = rng.Next(1, 10);
            intArray = new int[] { a, b, c, d, e };
            Console.WriteLine($"\n*** Array667 ***\n");
            Console.WriteLine($"This array: {{{a} {b} {c} {d} {e}}} contains {{6, 6}} or {{6, 7}} {loops.Array667(intArray)} times.\n");

            // NoTriples

            a = rng.Next(1, 5);
            b = rng.Next(1, 5);
            c = rng.Next(1, 5);
            d = rng.Next(1, 5);
            e = rng.Next(1, 5);
            intArray = new int[] { a, b, c, d, e };
            resultString = loops.NoTriples(intArray) ? "doesn't" : "does";
            Console.WriteLine($"\n*** noTriples ***\n");
            Console.WriteLine($"This array: {{{a} {b} {c} {d} {e}}} {resultString} contain the same three numbers consecutively.\n");

            // Pattern51

            a = rng.Next(1, 10);
            b = rng.Next(1, 10);
            c = rng.Next(1, 10);
            d = rng.Next(1, 10);
            e = rng.Next(1, 10);
            intArray = new int[] { a, b, c, d, e };
            resultString = loops.Pattern51(intArray) ? "does" : "doesn't";
            Console.WriteLine($"\n*** Pattern51 ***\n");
            Console.WriteLine($"This array: {{{a} {b} {c} {d} {e}}} {resultString} contain the pattern of n, n+5, n-1.\n");


        }
    }
}

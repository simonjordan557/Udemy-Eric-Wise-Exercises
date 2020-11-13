using System;
using System.Linq;
using Make2Library;

namespace Make2
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();
            Random rng = new Random();

            int[] a = new int[rng.Next(1, 7)];
            Console.WriteLine($"Array a: ");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rng.Next(0, 10);
                Console.Write($"{a[i]}  ");
            }

            int[] b = new int[rng.Next(1, 7)];
            Console.WriteLine($"\n\nArray b: ");
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = rng.Next(0, 10);
                Console.Write($"{b[i]}  ");
            }

            int[] c = evaluator.Go(a, b);
            Console.WriteLine($"\n\nResult: {c[0]}  {c[1]}");
        }

        
    }
}

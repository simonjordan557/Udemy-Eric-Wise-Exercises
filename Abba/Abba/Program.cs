using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first word:");
            string WordA = Console.ReadLine();

            Console.WriteLine("Enter the second word:");
            string wordB = Console.ReadLine();

            Console.WriteLine("{0}{1}{1}{0}", WordA, wordB);
            Console.ReadLine();

        }
    }
}

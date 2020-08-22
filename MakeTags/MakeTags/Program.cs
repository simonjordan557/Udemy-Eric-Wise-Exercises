using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeTags
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your tag:");
            string tag = Console.ReadLine();

            Console.WriteLine("Please enter your content:");
            string content = Console.ReadLine();

            Console.WriteLine("<{0}>{1}</{0}>", tag, content);
            Console.ReadLine();

        }
    }
}

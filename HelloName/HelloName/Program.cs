using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name;

            name = Console.ReadLine();

            Console.WriteLine("Hello " + name);
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey there! What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("/nHi there, " + name + "!");
            Console.ReadLine();

        }
    }
}

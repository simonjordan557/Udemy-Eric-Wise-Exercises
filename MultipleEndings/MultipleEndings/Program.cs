using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleEndings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "";

            while (word.Length < 2)
            {
                Console.WriteLine("Please enter your word to be echoed (Minimum 2 characters:");
                word = Console.ReadLine();
            }
           

            string echo = word.Substring((word.Length - 2), 2);
            Console.WriteLine("{0}{0}{0}", echo);
            Console.ReadLine();



        }
    }
}

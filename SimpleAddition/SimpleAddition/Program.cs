using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAddition 
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number ");
            string userinput = Console.ReadLine();
            int number1 = int.Parse(userinput);

            Console.Write("Enter the second number ");
            userinput = Console.ReadLine();
            int number2 = int.Parse(userinput);

            int sum = (number2 + number1);
                Console.Write("Sum total is " + sum);

            Console.ReadLine();
            /* multiple
            line
            comment */

           



        }
    }
}

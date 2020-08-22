using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkipSum
{
    class play
    {
        int a;
        int b;
        int sum;
        int display;

        public void Go()
        {
            Console.WriteLine("Enter the first number: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the second number: ");
            b = int.Parse(Console.ReadLine());

            sum = a + b;

            if (sum <= 9 || sum >= 20)
            {
                display = sum;
            }

            else
            {
                display = 20;
            }

            Console.WriteLine("\nYour number is {0}.", display);
            Console.ReadLine();
        }
    }
}

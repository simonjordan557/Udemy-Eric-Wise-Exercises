using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveSix
{
    class Play
    {
        int a;
        int b;
        bool six;

        public void Go()
        {
            GetInt();
            six = SixTest(a, b);
            if (six == true)
            {
                Console.WriteLine("Those numbers Love Six!");
            }

            else
            {
                Console.WriteLine("Those numbers DO NOT Love Six.");
            }

            Console.ReadLine();
        }

        private void GetInt()
        {
            Console.WriteLine("What is the first number? : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the second number? : ");
            b = int.Parse(Console.ReadLine());
        }

        private bool SixTest(int i, int j)
        {
            if (i == 6)
            {
                return true;
            }

            else if (j == 6)
            {
                return true;
            }

            else if ((i + j) == 6)
            {
                return true;
            }

            else if ((i - j) == 6)
            {
                return true;
            }

            else if ((i - j) == -6)
            {
                return true;
            }

            else return false;
        }
    }
}

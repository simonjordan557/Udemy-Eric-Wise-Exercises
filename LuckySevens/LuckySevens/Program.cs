using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckySevens
{
    class Program
    {
        static void Main(string[] args)
        {
            int dice1;
            int dice2;
            int totalnumberofsevens = 0;
            Random rng = new Random();

            for (int i = 1; i <= 100; i++)
            {
                dice1 = rng.Next(1, 7);
                dice2 = rng.Next(1, 7);

                if (dice1 + dice2 == 7)
                {
                    totalnumberofsevens++;
                }
            }
            Console.WriteLine("I rolled {0} sevens!", totalnumberofsevens);
            Console.ReadLine();
        }   
    }
}

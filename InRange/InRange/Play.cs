using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRange
{
    class Play
    {
        int a;
        string outsideString;

        public void Go()
        {
            outsideString = GetOutside();
            a = GetInt();

            if (outsideString == "N")
            {
                if (a <= 1 || a >= 10)
                {
                    Console.WriteLine("That is in range!");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("That is not in range.");
                    Console.ReadLine();
                }
            }


            else if (outsideString == "Y")
            {
                
                if (a <= 1 || a >= 10)
                    {
                        Console.WriteLine("That is not in range.");
                        Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("That is in range!");
                        Console.ReadLine();
                    }
            }

            else
            {
                Console.WriteLine("\nINVALID RESPONSE!!!!");
                GetOutside();
            } 
        }

        public string GetOutside()
        {
            Console.WriteLine("\nDo you want to test for 1-10? (Y or N: ");
            outsideString = Console.ReadLine();
            outsideString = outsideString.ToUpper();
            return outsideString;
           
        }

        public int GetInt()
        {
            Console.WriteLine("\nWhat is the number you wish to test?");
            int x = int.Parse(Console.ReadLine());
            return x;
        }


    }
}

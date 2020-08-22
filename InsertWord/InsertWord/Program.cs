using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertWord
{
    class Program
    {
       public static void Main(string[] args)
        {
            string container = "";
            while (container.Length != 4)
            {
                Console.WriteLine("Enter your container:");
                container = Console.ReadLine();
            }

           



                string pre = container.Substring(0, 2);
                string post = container.Substring(2, 2);

                Console.WriteLine("Enter your content:");
                string content = Console.ReadLine();

                Console.WriteLine("{0}{1}{2}", pre, content, post);
                Console.ReadLine();

            }
        }
    }


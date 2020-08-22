using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHalf
{
    class Game
    {
        string word;
        string half;
        int semi;

        public void Play()
        {
            Console.WriteLine("What is your choice of word to be halved? ");
            word = Console.ReadLine();
            semi = word.Length / 2;
            half = word.Substring(0, semi);

            if ((word.Length % 2) == 0)
            {
                Console.WriteLine(half);
                Console.ReadLine();
            }


            else
            {
                Console.WriteLine("Word must contain an even number of letters! ");
                Play();
            }
        }
    }
}

   
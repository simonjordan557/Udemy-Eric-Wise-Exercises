using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaughtSpeeding
{
    class Game
    {
        int outcome;
        bool isBirthday;
        string birthdayString;
        int speed;
        int limit;
        int upperLimit;

        public void Play()
        {
            limit = 60;
            upperLimit = 80;

            Console.WriteLine("\nHow fast were you driving, Sir? ");
            speed = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIs it your birthday or something? (Y or N:" );
            birthdayString = Console.ReadLine().ToUpper();

            if (birthdayString == "Y")
            {
                isBirthday = true;
            }

            else if (birthdayString == "N")
            {
                isBirthday = false;
            }

            else
            {
                Console.WriteLine("\nYou ain't makin' sense! Is it your birthday or not?! ");
                birthdayString = Console.ReadLine().ToUpper();
            }

            outcome = TicketOutcome(speed, isBirthday);
            
            if (outcome == 0)
            {
                Console.WriteLine("\nOK, you're free to go.");
                Play();
            }

            else if (outcome == 1)
            {
                Console.WriteLine("\nYou were speeding, at {0} mph. you get a £50 fine.", speed);
                Play();
            }

            else if (outcome == 2)
            {
                Console.WriteLine("\nYou were going crazy fast at {0} mph! That's a £100 fine. ", speed);
                Play();
            }
        }

        private int TicketOutcome(int x, bool y)
        {
            if (y == true)
            {
                limit = limit + 5;
                upperLimit = upperLimit + 5;
            }

            if (speed <= limit)
            {
                return 0;
            }

            else if (speed > limit && speed <= upperLimit)
            {
                return 1;
            }

            else
            {
                return 2;
            }
        }
    }
}

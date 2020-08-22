using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    class Play
    {
        int day;
        string holidayString;
        bool holiday;
        string alarm;

        public void Go()
        {
            Console.WriteLine("Which day of the week is it?\n\n1: Sunday\n2: Monday\n3: Tuesday\n4: Wednesday\n5: Thursday\n6: Friday\n7: Saturday\n\nENTER THE APPROPRIATE NUMER: ");
            day = int.Parse(Console.ReadLine());

            Console.WriteLine("\nAre you on holiday? (Y or N): ");
            holidayString = Console.ReadLine();
            holidayString = holidayString.ToUpper();

            if (holidayString == "Y")
            {
                holiday = true;
            }

            else if (holidayString == "N")
            {
                holiday = false;
            }

            else
            {
                Console.WriteLine("INVALID RESPONSE\n");
                Go();
            }

            if (holiday == true)
            {
                if (day == 1 || day == 7)
                {
                    alarm = "not set!";
                }

                else if (day >=2 && day <= 6)
                {
                    alarm = "10.00.";
                }

                else
                {
                    Console.WriteLine("INVALID DAY!\n");
                    Go();
                }
            }

            else
            {
                if (day == 1 || day == 7)
                {
                    alarm = "10.00.";
                }

                else if (day >= 2 && day <= 6)
                {
                    alarm = "7.00.";
                }

                else
                {
                    Console.WriteLine("INVALID DAY!\n");
                    Go();
                }          
            }

            Console.WriteLine("Your alarm time is {0}", alarm);
            Console.ReadLine();
        }
    }
}

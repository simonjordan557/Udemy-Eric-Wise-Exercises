using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CanHazTable
{
    class Game
    {
        private int _yourStyle;
        private int _dateStyle;
        public string rejectionReason;


        public Game()
        {
            _yourStyle = GetAndValidateInt("Rate your own style, 0 - 10?");
            _dateStyle = GetAndValidateInt("Rate your own style, 0 - 10?");
        }

        public int TableTest()
        {

            if (_yourStyle <= 2 || _dateStyle <= 2)
            {
                if (_yourStyle <= 2)
                {
                    rejectionReason = "You are a slob.";
                    return 0;
                }

                else
                {
                    rejectionReason = "Your date is a slob.";
                    return 0;
                }

            }

            else if (_yourStyle >= 8 || _dateStyle >= 8)
            {
                return 2;
            }

            else
            {
                return 1;
            }



            
        }

            private int GetAndValidateInt(string message)

            {

                bool validInt = false;
                int validatedInt;


                while (true)
                {
                    Console.WriteLine($"\n{message}");

                    string input = Console.ReadLine();

                    validInt = int.TryParse(input, out validatedInt);

                    if (!validInt)
                    {
                        Console.WriteLine($"\n{input} is not a valid response.");
                    }

                    else
                    {
                        if (validatedInt >= 0 && validatedInt <= 10)
                        {
                            return validatedInt;
                        }

                        else
                        {
                            Console.WriteLine($"\n{input} is not in the range 0 - 10.");
                        }
                    }

                }
            }
        }
    }

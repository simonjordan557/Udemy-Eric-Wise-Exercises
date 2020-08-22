using System;
using System.Collections.Generic;
using System.Text;

namespace GreatParty
{
    class Game
    {
        private bool _isWeekend;
        private string _isWeekendInput;
        private bool _validateCigars;
        private int _cigars;
        private string _cigarsInput;
        public string reasonForFailure;

        public Game()
        {
            GetAndValidateIsWeekend();
            GetAndValidateCigars();

        }

        public bool IsPartyGreat()
        {
            if (_cigars < 40)
            {
                reasonForFailure = "\nNot enough cigars!";
                return false;
            }

            else if (!_isWeekend && (_cigars > 60))
            {
                reasonForFailure = "\nToo many cigars on a weeknight!";
                return false;
            }

            else
            {
                return true;
            }
        }

        private void GetAndValidateCigars()
        {
            while (!_validateCigars)
            {
                Console.WriteLine("\nHow many cigars at the party?");

                _cigarsInput = Console.ReadLine();

                _validateCigars = int.TryParse(_cigarsInput, out _cigars);

                if (!_validateCigars)
                {
                    Console.WriteLine($"\n{_cigarsInput} is not a valid response.");
                }

            }
        }

        private void GetAndValidateIsWeekend()
        {
            while ((_isWeekendInput != "N") && (_isWeekendInput != "Y"))
            {
                Console.WriteLine("\nIs it the weekend? Y or N");

                _isWeekendInput = Console.ReadLine().ToUpper();

                if (_isWeekendInput == "Y")
                {
                    _isWeekend = true;
                }

                else if (_isWeekendInput == "N")
                {
                    _isWeekend = false;
                }

                else
                {
                    Console.WriteLine($"\n{_isWeekendInput} is not a valid response.");
                }
            }
        }
    }
}

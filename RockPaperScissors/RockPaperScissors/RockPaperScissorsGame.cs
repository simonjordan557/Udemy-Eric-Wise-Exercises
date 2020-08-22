using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RockPaperScissorsGame
    {
        private Random rng;
        private int wins = 0;
        private int losses = 0;
        private int ties = 0;
        public string userchoice;
        public string computerchoice;

        public RockPaperScissorsGame()
        {
            rng = new Random();
        }

        public void Play()
        {


            userchoice = PromptUser();

            while (userchoice != "Q")
            {
                //Do stuff to play the game
                computerchoice = GetComputerChoice();
                Console.WriteLine("You chose " + ConvertChoiceToWord(userchoice) + ".");
                Console.WriteLine("The computer chose " + ConvertChoiceToWord(computerchoice) + ".");

                if (userchoice == "R")
                {
                    if (computerchoice == "P")
                    {
                        LoseState();
                    }
                    if (computerchoice == "S")
                    {
                        WinState();
                    }
                    else
                    {
                        TieState();
                    }
                }

                if (userchoice == "P")
                {
                    if (computerchoice == "R")
                    {
                        WinState();
                    }
                    if (computerchoice == "S")
                    {
                        LoseState();
                    }
                    else
                    {
                        TieState();
                    }
                }

                if (userchoice == "S")
                {
                    if (computerchoice == "R")
                    {
                        LoseState();
                    }
                    if (computerchoice == "P")
                    {
                        WinState();
                    }
                    else
                    {
                        TieState();
                    }
                }
            }
        }
        private string PromptUser()
        {
            while (true)
            {
                Console.WriteLine("Current Score: {0} Wins, {1} Losses, {2} Ties.", wins, losses, ties);
                Console.Write("Rock, Paper, Scissors, or Quit? Press R, P, S, or Q.");
                string choice = Console.ReadLine();

                if (choice == "R" || choice == "P" || choice == "S" || choice == "Q")
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("That was not a valid choice.");
                }
            }
        }

        private string GetComputerChoice()
        {
            int choice = rng.Next(1, 4);

            if (choice == 1)
            {
                return "R";
            }
            else if (choice == 2)
            {
                return "P";
            }
            else
            {
                return "S";
            }
        }

        private string ConvertChoiceToWord(string choice)
        {
            if (choice == "R")
            {
                    return "Rock";
            }
            else if (choice == "P")
            {
                return "Paper";
            }
            else
            {
                return "Scissors";
            }
        }

        private void WinState()
        {
            wins = wins + 1;
            Console.WriteLine("You Won!!!");
            Play();
        }

        private void LoseState()
        {
            losses = losses + 1;
            Console.WriteLine("You lost...");
            Play();
        }

        private void TieState()
        {
            ties = ties + 1;
            Console.WriteLine("A draw! The tension rises.");
            Play();
        }
    }
}

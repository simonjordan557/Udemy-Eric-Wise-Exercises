using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Hangman
    {
        
        static string guess;
        int lives = 10;
        int correctguess;
        int totalguesses;
        char charguess;
        bool FoundLetter = false;

        static string[] database = new string[] { "father", "mother", "sister", "blonde", "fluffy", "pretty",
            "hunter", "kissed", "season", "knight"};

       static Random rng = new Random();

        static string solution = database[rng.Next(0, database.Length)];
        



        char[] loggedguesses = new char[35];
        char[] solutionarray = new char[solution.Length];
        char[] detectedarray = new char[solution.Length];


        public void Initialise()
        {
            
            Console.WriteLine(solution);

            for (int i = 0; i < solution.Length; i++)
            {
                solutionarray[i] = (solution[i]);
            }
            Console.WriteLine(solutionarray);

            for (int i = 0; i < solution.Length; i++)
            {
                detectedarray[i] = '_';
            }
            Play();
        }

        public void Play()
        {

        
            //This will contain the main gameplay loop

            //Console.Clear();

            Console.WriteLine("\nLives remaining: " + lives + "\n\n");

            for (int i = 0; i < solution.Length; i++)
            {
                Console.Write("\t{0}", detectedarray[i]);
            }


            if (lives > 0 && correctguess < solution.Length) 
            {
                Console.WriteLine("Please enter your guess. ");
                Hangman.guess = Console.ReadLine();
                Hangman.guess = Hangman.guess.ToUpper();
                charguess = Hangman.guess[0];
                CheckGuess(charguess);
            }
            else if (lives <= 0)
            {
                FailState();
            }

        else if (correctguess >= solution.Length)
            {
                WinState();
            }
        }

        

        private void CheckGuess(Char x)
        {
            //This method checks if the player's guessed char is present in the solution

            if (loggedguesses.Contains(x))
            {
                Console.WriteLine("You already guessed letter " + x + " !");
                lives--;
                totalguesses++;
                Play();
            }
            else
            {
                for (int i = 0; i < solution.Length; i++)
                {
                    if (x == solutionarray[i])
                    {
                        FoundLetter = true;
                        detectedarray[i] = x;
                        GoodGuess(x);
                    }

                    else
                    {
                        FoundLetter = false;
                        BadGuess(x);
                        

                    }
                }
            }


              
        }

        private void GoodGuess(char x)
        {
            totalguesses++;
            loggedguesses[totalguesses] = x;
            correctguess++;
            Console.WriteLine("WELL DONE! CORRECT GUESS!");
            Play();

        }   

        private void BadGuess(char x)
        {
            lives--;
            totalguesses++;
            loggedguesses[totalguesses] = x;
            Console.WriteLine("Bad luck, yopu lost a life.");
            Play();

        }
        private void FailState()
        {
            Console.WriteLine("\nYou're out of lives! Game Over!!");
            PlayAgain();
        }
        
        private void WinState()
        {
            Console.WriteLine("\nYou won! You used " + totalguesses + "guesses, well done.");
            PlayAgain();
        }
        
        private void PlayAgain()
        {
            Console.WriteLine("Play Again? Y or N. ");
            string replay = Console.ReadLine();
            replay = replay.ToUpper();
            if (replay == "Y")
            {
                Initialise();
            }
            else if (replay == "N")
            {
                Console.WriteLine("Thanks for playing!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid Selection");
                return;
            }
        } 
    }
}


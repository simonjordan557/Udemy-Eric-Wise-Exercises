using System;

namespace CanHazTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the program.");

            Game game = new Game();
            int outcome = game.TableTest();

            if (outcome == 0)
            {
                Console.WriteLine($"\nNo table for you! {game.rejectionReason}");
            }

            else if (outcome == 1)
            {
                Console.WriteLine("\nMaybe you can have a table. Wait here...");
            }

            else
            {
                Console.WriteLine("\nOf course, we have a table for you, follow me...");
            }

            Console.ReadLine();
        }
    }
}

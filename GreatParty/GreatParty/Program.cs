using System;

namespace GreatParty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Game....");

            Game game = new Game();
            Console.WriteLine($"\nIs the party great? {game.IsPartyGreat()}. {game.reasonForFailure}");
            Console.ReadLine();
            
        }
    }
}

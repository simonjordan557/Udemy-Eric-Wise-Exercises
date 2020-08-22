using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word: ");
            string userEntry = Console.ReadLine();
            int length = userEntry.Length;
            char[] userEntryArray = userEntry.ToCharArray();           
            string returnedArrayString = "";

            

            for (int i = (length - 1); i >= 0; i--)
            {
                returnedArrayString += userEntryArray[i];
            }
           
            Console.WriteLine($"String reversed is {returnedArrayString}.");
            Console.ReadLine();
        }
    }
}

using System;

namespace AdventureGame
{
    class Program
    {
        static void Main()
        {

            string characterName;

            Console.WriteLine("Ending's Dawn");
            Console.WriteLine("Welcome to the beginning of the end...");
            Console.WriteLine("\nWhat is your name?\n");
            characterName = Console.ReadLine();
            Console.WriteLine("\nWelcome, " + characterName + ".\n");

        }
    }
}

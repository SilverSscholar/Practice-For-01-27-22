using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //show user a menu 

            Console.WriteLine("Main Menu:");

            //offer options to user 
            // ask for their choice
            //ADD TWO NUMBERS
            Console.WriteLine("1. Add two numbers");
            // SUBTRACT TWO NUMBERS
            Console.WriteLine("2. Subtract two numbers");
            //REMOVE WHITESPACE FROM A STRING
            Console.WriteLine("3. Remove whitespecae from a string");
            //REVERSE A STRING
            Console.WriteLine("4. Reverse a string");
            // ATTEMPT ERROR HANDLING (user does something i am not expecting)
            // do their choice
            Console.WriteLine("Enter your choice");
            char userChoice = Console.ReadKey().KeyChar;

            Console.WriteLine("\n");
            Console.WriteLine($"Your choice was {userChoice}");
            // go back to menu 

            switch (userChoice)
            {
                case '1' :
                    Console.WriteLine("Your choice was to add two numbers");
                    break;
                case '2':
                    Console.WriteLine("Your choice was to Subtract two numbers");
                    break;
                case '3':
                    Console.WriteLine("Your choice was to Remove Whitespace from a string");
                    break;
                case '4':
                    Console.WriteLine("Your choice was to reverse a string");
                    break;
            }
            // go back to beginning
            // unlesss choice is exit
            //exit application
            //

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
            Console.WriteLine("Program exited");

        }
    }
}

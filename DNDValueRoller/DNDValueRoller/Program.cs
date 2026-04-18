// 4/17/2026
// Simple console application that will randomly generate a number between a minimum and
// maximum value provided by the user.
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace DNDValueRoller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring random object
            Random RNG = new Random();

            // Declaring values
            int intUserInput = 1;
            string userInput;

            // While loop to allow user to roll as many times as they want or quit the program
            while (intUserInput != 0)
            {
                // Prompting user to roll or quit
                Console.Write("Enter 1 to roll or 0 to quit: ");
                userInput = Console.ReadLine()!;
                intUserInput = int.Parse(userInput);
                if (intUserInput == 1)
                {
                    // Calling method to roll values
                    RollValue();
                }
                else if (intUserInput == 0)
                {
                    // Exiting program
                    Console.WriteLine("Exiting program...");
                }
                else
                {
                    // Invalid input
                    Console.WriteLine("Invalid input, please try again.");
                }
            }

        }

        /// <summary>
        /// Method to randomly generate a number between a minimum and maximum value provided by the user
        /// </summary>
        public static void RollValue()
        {
            // Declaring random object
            Random RNG = new Random();

            int min;
            int max;
            int timesRolled;
            int numberRolled;
            int total = 0;
            string userInput;

            // Prompting user for minimum and maximum values
            Console.WriteLine("\n----------------------");
            Console.Write("Enter minimum value: ");
            userInput = Console.ReadLine()!;

            min = int.Parse(userInput);

            Console.Write("Enter maximum value: ");
            userInput = Console.ReadLine()!;

            max = int.Parse(userInput);

            // Prompting user for how many times to roll
            Console.Write("Enter how many times to roll: ");
            userInput = Console.ReadLine()!;
            timesRolled = int.Parse(userInput);

            // Tell user dice is being rolled
            Console.WriteLine($"\nRolling {min}-{max} {timesRolled} time(s)\n");

            // For loop to calculate each dice roll and total of all rolls
            for (int i = 0; i < timesRolled; i++)
            {
                numberRolled = RNG.Next(min, max + 1);

                Console.WriteLine($"\t{i+1}: {numberRolled}");

                total = total + numberRolled;
            }

            // Display total of all rolls
            Console.WriteLine($"\nTotal: {total}");
            Console.WriteLine("----------------------\n");
        }
    }
}

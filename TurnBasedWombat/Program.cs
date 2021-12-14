using System;
using System.Collections.Generic;
using System.Linq;

namespace TurnBasedWombat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Credits
            Console.WriteLine("TBW starting up...");
            Console.WriteLine("TWB (Turn-Based Wombat) ver 1.0.0 by Samantha Roy");

            // Init Variables & Arrays
            string[] pkmnNameArr = File.ReadAllLines(@"F:\Visual Studio 2022\Projects\TurnBasedWombat\data-files\PkmnNames.txt");
            string[] pkmnTypeArr = File.ReadAllLines(@"F:\Visual Studio 2022\Projects\TurnBasedWombat\data-files\PkmnTypes.txt");
            bool loop = true;
            string selection = "";
            
            // -- MAIN MENU --
            while (loop)
            {
                // Get user's menu selection
                selection = GetMenuSelection();

                // Begin switch statement
                switch (selection)
                {
                    // Generate random pokemon
                    case "1":
                        Console.WriteLine();
                        break;

                    // Show random pokemon's stats
                    case "2":
                        break;

                    // Save random pokemon's stats to a .txt files, (the 'save-data' folder)
                    case "3":
                        break;

                    // End the menu loop
                    case "4":
                        break;

                    // Catch all invalid responses
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Display the menu to the user, reading their input
        /// </summary>
        /// <returns>the User's input for the main switch statement</returns>
        public static string GetMenuSelection()
        {
            // Print Menu Options
            Console.WriteLine("\n");
            Console.WriteLine(
                "1. Generate a random pokemon\n" +
                "2. See your randomly generated pokemon's stats\n" +
                "3. Save your random pokemon\n" +
                "4. Quit"
                );

            // Get user input for menu
            string uString = "";
            Console.Write("Please enter menu selection (1-4): \n");
            uString = Console.ReadLine();
            return uString;
        }

        /// <summary>
        /// Method to return a random integer between any 2 given values
        /// </summary>
        /// <param name="floor">Lowest possible value to be rolled (inclusive)</param>
        /// <param name="roof">Highest possible value to be rolled (exclusive)</param>
        /// <returns>Randomized value between the floor & roof</returns>
        public static int rollDice(int floor, int roof)
        {
            // Compressing the random function into one line will be very helpful for giving random parameters
            Random random = new Random();
            return random.Next(floor, roof);
        }

        
    }
}
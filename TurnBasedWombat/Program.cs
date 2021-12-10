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
            
            // -- MAIN MENU --
            while (loop)
            {
                Console.WriteLine("\n");
                Console.WriteLine(
                    "1. See random pokemon's stats\n" +
                    "2. Generate random pokemon\n" +
                    "3. Save your random pokemon\n" +
                    "4. Quit"
                    );

                // Get user input for menu
                string uString = "";
                Console.Write("Please enter menu selection (1-4): \n");
                uString = Console.ReadLine();
                loop = MenuLooper(uString, pkmnNameArr, pkmnTypeArr);  
            }
        }

        /// <summary>
        /// Simple Method to make sure the menu loop doesn't go on forever
        /// </summary>
        /// <returns>the yes or no value of the loop variable in Main</returns>
        public static bool MenuLooper(string uString, string[] pkmnArr, string[] pkmnArr2)
        {
            switch (uString)
            {
                // Show random pokemon's stats
                case "1":
                    Console.WriteLine("Show stats");
                    return true;

                // Generate a random pokemon
                case "2":
                    Console.WriteLine("Generating pokemon");
                    Pokemon randGenPkmn = new Pokemon(
                        pkmnArr[rollDice(0, pkmnArr.Length)],
                        rollDice(1, 50),
                        pkmnArr2[rollDice(0, pkmnArr2.Length)],
                        rollDice(1, 10)
                        );
                    return true;

                // Save the random pokemon's data
                case "3":
                    Console.WriteLine("Saving pokemon");
                    return true;

                // Quit the program
                case "4":
                    Console.WriteLine("Quitting program");
                    return false;

                // If user inputs an invalid selection option
                default:
                    Console.WriteLine("Please input a valid character");
                    return true;
            }
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
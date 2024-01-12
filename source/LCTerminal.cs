using System;
using System.Collections.Generic;
using System.Text;

namespace LC_Terminal
{
    internal class LCTerminal
    {
        static bool isProgramContinue = true;
        static string userCommand;
        static List<string> validCommands = new List<string> { "help", "moons", "store", "bestiary", "storage", "other" };


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Clear();
            DisplayInitialText();

            Console.ReadLine();

            while (isProgramContinue)
            {
                Console.Clear();
                DisplayHomePage();

                userCommand = Console.ReadLine().ToLower();
                if (validCommands.Contains(userCommand))
                {
                    ProcessUserCommand(userCommand);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("[There was no action supplied with the word.]");
                    Console.ReadLine();
                    // Back to Home Page
                }
            }
        }

        static void DisplayInitialText()
        {
            DateTime currentDate = DateTime.Now;
            string initialText = $"Welcome to the FORTUNE-9 OS\n          Courtesy of the Company\n\n" +
                $"Happy {currentDate.DayOfWeek}.\n\n" +
                $"Type \"Help\" for a list of commands.";

            Console.WriteLine(initialText);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        static void DisplayHomePage()
        {
            string homePageText = ">MOONS\n" +
                "To see the list of moons the autopilot can route to.\n\n" +
                ">STORE\nTo see the company store's selection of useful items.\n\n" +
                ">BESTIARY\nTo see the list of wildlife on record.\n\n" +
                ">STORAGE\nTo access objects placed into storage.\n\n" +
                ">OTHER\nTo see the list of other commands";

            Console.WriteLine(homePageText);
        }

        static void ProcessUserCommand(string command)
        {
            switch (command)
            {
                case "help":
                    // Implement help logic
                    break;
                case "moons":
                    Console.Clear();
                    DisplayMoonsText();
                    userCommand = Console.ReadLine();
                    break;
                case "store":
                    // Implement store logic
                    break;
                case "bestiary":
                    // Implement bestiary logic
                    break;
                case "storage":
                    // Implement storage logic
                    break;
                case "other":
                    // Implement other logic
                    break;
            }
        }

        static void DisplayMoonsText()
        {
            string moonsText = "Welcome to the exomoons catalogue.\n" +
                "To route the autopilot to a moon, use the word\nROUTE.\nTo learn about any moon, use the word INFO.\n" +
                "___________________________\n\n" +
                "* The Company Building   //   Buying at 100%.\n" +
                "* Experimentation\n" +
                "* Assurance\n" +
                "* Vow\n\n" +
                "* Offense\n" +
                "* March\n\n" +
                "* Rend \n" +
                "* Dine\n" +
                "* Titan\n";

            Console.WriteLine(moonsText);
        }
    }
}

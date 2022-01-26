using System;
using System.Collections.Generic;

namespace Planet_Generator
{
    internal static class Program
    {
        public static void Main()
        {
            //Creates an empty list for the Planet objects
            List<Planet> planetList = new List<Planet>();

            //Prompts the user to enter the number of planets they would like to generate
            Console.Write("Enter the number of planets to be generated: ");
            int numberOfPlanets = Convert.ToInt32(Console.ReadLine());

            //Creates planets
            for (int i = 0; i < numberOfPlanets; i++)
            {
                Planet p = new Planet(
                    //Generate the planet name
                    PlanetNameGen(),
                    //Generate the planet size
                    Math.Round(PlanetGen(5, 10), 2),
                    //Generate the planet pop
                    Math.Round(PlanetGen(0, 5), 2),
                    //Generate the planet type
                    Convert.ToInt32(Math.Round(PlanetGen(1, 10), 0)),
                    //Determine whether the planet will be a gas giant
                    DetermineIfGasGiant());

                //Add the newly generated planet to the list
                planetList.Add(p);
            }

            Console.WriteLine("\n\nPlanets Generated. Please choose an option from the list below.");

            //Sets the variable responsible for ending the loop to false
            bool endLoop = false;

            do
            {
                //Gives the user the list of commands and asks for an input
                Console.WriteLine("\n==============================================================\n");
                Console.Write("1) Choose a random planet to display the stats of.\n" +
                              "2) Choose a specific planet number to display the stats of.\n" +
                              "3) Display the stats of all generated planets.\n" +
                              "4) Find a planet based on a specific stat.\n" +
                              "\n" +
                              "Enter any other option to end the program.\n" +
                              "\n" +
                              "What do you want to do? : ");

                int userChoice = Convert.ToInt32(Console.ReadLine());

                //The switch statement that determines the function based on the users choice
                switch (userChoice)
                {
                    case 1:
                        //Get stats of a random planet
                        Methods.RandomInfo(planetList, numberOfPlanets);
                        break;
                    case 2:
                        //Ger stats of a specific planet based on the planet's number
                        Methods.PlanetInfo(planetList);
                        break;
                    case 3:
                        //Get stats on all planets
                        Methods.AllInfo(planetList);
                        break;
                    default:
                        //Entering anything else causes the program to end
                        endLoop = true;
                        break;
                }
            } while (!endLoop);
        }

        public static int RandomNum(int min, int max)
        {
            Random rd = new Random();

            int randomNumber = rd.Next(min, max);

            return randomNumber;
        }

        private static string[] nameF = {"Gal", "En", "Mee", "Vel", "Nos", "Ox", "Ova", "Nee", "Are", "Blisk"};
        private static string[] nameL = {"ala", "sque", "olo", "nix", "kano", "boah", "elin", "wel", "as", "zen"};

        private static string PlanetNameGen()
        {
            return nameF[RandomNum(0, 10)] + nameL[RandomNum(0, 10)];
        }

        private static double PlanetGen(int min, int max)
        {
            double wholeValue = RandomNum(min, max);
            double decimalValue = RandomNum(0, 100) / 100.00;

            return wholeValue + decimalValue;
        }

        public static bool DetermineIfGasGiant()
        {
            double determine = RandomNum(0, 100) / 100.0;

            if (determine >= 0.90)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
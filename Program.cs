using System;
using System.Collections.Generic;

namespace Planet_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPlanets;

            List<Planet> planetList = new List<Planet>();

            Console.Write("Enter the number of planets to be generated: ");
            numberOfPlanets = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfPlanets; i++)
            {
                Planet p = new Planet(PlanetNameGen(), Math.Round(PlanetGen(5, 10), 2), Math.Round(PlanetGen(0, 5),2), Convert.ToInt32(Math.Round(PlanetGen(1, 4), 0)));
                planetList.Add(p);
            }

            Planet randomPlanet = planetList[RandomNum(0, numberOfPlanets)];
            Console.Write($"The random planet chosen was Planet {planetList.IndexOf(randomPlanet) + 1}, {randomPlanet.name}. Here are the stats:\n" +
                $"NAME: {randomPlanet.name}\n" +
                $"SIZE: {randomPlanet.size}\n" +
                $"POPULATION: {randomPlanet.population}\n" +
                $"TYPE: ");
            randomPlanet.PrintPlanetType();

            Console.Write("If you would like to see the stats of any other planet, enter the number now.\n" +
            "Otherwise, enter 'a' to see all planet's stats, or press any other key to end the program: ");

            string nextChoice = Console.ReadLine();

            while (nextChoice == Convert.ToString('a') || (Convert.ToInt32(nextChoice) <= planetList.Count) && Convert.ToInt32(nextChoice) > 0)
            {
                if (nextChoice == Convert.ToString('a'))
                {
                    Console.WriteLine("Here are the stats of all planets:\n\n");

                    for (int i = 0; i < planetList.Count; i++)
                    {
                        Console.WriteLine("------------------\n");
                        Console.WriteLine($"PLANET {planetList.IndexOf(planetList[i]) + 1}");
                        planetList[i].PrintPlanetName();
                        planetList[i].PrintPlanetSize();
                        planetList[i].PrintPlanetPop();
                        planetList[i].PrintPlanetType();
                    }
                }
                else if (Convert.ToInt32(nextChoice) <= planetList.Count && Convert.ToInt32(nextChoice) > 0)
                {
                    Console.WriteLine($"------------------\n");
                    Console.WriteLine($"PLANET {planetList.IndexOf(planetList[Convert.ToInt32(nextChoice) - 1]) + 1}");
                    planetList[Convert.ToInt32(nextChoice) - 1].PrintPlanetName();
                    planetList[Convert.ToInt32(nextChoice) - 1].PrintPlanetSize();
                    planetList[Convert.ToInt32(nextChoice) - 1].PrintPlanetPop();
                    planetList[Convert.ToInt32(nextChoice) - 1].PrintPlanetType();
                }

                Console.Write("If you would like to see the stats of any other planet, enter the number now." +
                    "Otherwise, enter 'a' to see all planet's stats, or press any other key to end the program: ");

                nextChoice = Console.ReadLine();
            }
        }

        public static int RandomNum(int min, int max)
        {
            Random rd = new Random();

            int randomNumber = rd.Next(min, max);

            return randomNumber;
        }

        

        public static string PlanetNameGen()
        {
            string[] nameF = { "Gal", "En", "Mee", "Vel" };
            string[] nameL = { "ala", "sque", "olo", "nix" };

            return nameF[RandomNum(0, 4)] + nameL[RandomNum(0, 4)];

        }

        public static double PlanetGen(int min, int max)
        {
            double wholeValue = RandomNum(min, max);
            double decimalValue = RandomNum(0, 100) / 100.00;

            return wholeValue + decimalValue;
        }
    }
}

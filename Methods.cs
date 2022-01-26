using System;
using System.Collections.Generic;

namespace Planet_Generator
{
    public static class Methods
    {
        public static void RandomInfo(List<Planet> planetList, int numberOfPlanets)
        {
            Planet randomPlanet = planetList[Program.RandomNum(0, numberOfPlanets)];
            Console.WriteLine(
                $"\n-------------------------------------------------------------------------------------\n" +
                $"The random planet chosen was Planet {planetList.IndexOf(randomPlanet) + 1}, {randomPlanet.name}. Here are the stats:");

            randomPlanet.PrintPlanetName();
            randomPlanet.PrintPlanetSize();
            randomPlanet.PrintPlanetPop();
            randomPlanet.PrintPlanetType();
        }

        public static void PlanetInfo(List<Planet> planetList)
        {
            Console.WriteLine("Which planet would you like to see the stats of? Enter the number here: ");
            int planetChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"------------------\n");
            Console.WriteLine(
                $"PLANET {planetList.IndexOf(planetList[Convert.ToInt32(planetChoice) - 1]) + 1}");

            planetList[Convert.ToInt32(planetChoice) - 1].PrintPlanetName();
            planetList[Convert.ToInt32(planetChoice) - 1].PrintPlanetSize();
            planetList[Convert.ToInt32(planetChoice) - 1].PrintPlanetPop();
            planetList[Convert.ToInt32(planetChoice) - 1].PrintPlanetType();
        }

        public static void AllInfo(List<Planet> planetList)
        {
            foreach (var p in planetList)
            {
                Console.WriteLine($"------------------\n");
                Console.WriteLine($"PLANET {planetList.IndexOf(p) + 1}:");
                planetList[planetList.IndexOf(p)].PrintPlanetName();
                planetList[planetList.IndexOf(p)].PrintPlanetSize();
                planetList[planetList.IndexOf(p)].PrintPlanetPop();
                planetList[planetList.IndexOf(p)].PrintPlanetType();
            }
        }
    }
}
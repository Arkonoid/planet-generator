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

        public static void SpecificInfo(List<Planet> planetList)
        {
            bool validChoice = false;

            Console.WriteLine("What would you like to search for?\n" +
                              "\n" +
                              "1) Search based on name.\n" +
                              "2) Search based on size.\n" +
                              "3) Search based on population.\n" +
                              "4) Search based on type.\n" +
                              "\n" +
                              "What do you want to do? : \n" +
                              "\n");
            do
            {
                Exceptions.ParseInt(Console.ReadLine(), out int userInput);

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("What planet would you like to search for? Enter the name below:\n");
                        string userPlanetChoice = Console.ReadLine();
                        bool planetFound = false;

                        for (int i = 0; i < planetList.Count; i++)
                        {
                            if (userPlanetChoice == planetList[i].name)
                            {
                                Console.WriteLine($"------------------\n");
                                Console.WriteLine(
                                    $"PLANET {planetList.IndexOf(planetList[i]) + 1}");

                                planetList[i].PrintPlanetName();
                                planetList[i].PrintPlanetSize();
                                planetList[i].PrintPlanetPop();
                                planetList[i].PrintPlanetType();

                                planetFound = true;
                                validChoice = true;
                            }
                        }

                        if (!planetFound)
                        {
                            Console.WriteLine("The planet you are looking for could not be found. Please try again.\n");
                            validChoice = true;
                        }

                        break;
                    case 2:
                        var option = true;
                        double minSize = 0;
                        double maxSize = 0;

                        Console.WriteLine("Enter the minimum size you would like to search for: ");

                        bool continueLoop;
                        
                        do
                        {
                            
                            Exceptions.ParseDouble(Console.ReadLine(), out minSize, out continueLoop);
                        } while (continueLoop);

                        Console.WriteLine("Enter the maximum size you would like to search for: ");
                        
                        do
                        {
                            Exceptions.ParseDouble(Console.ReadLine(), out maxSize, out continueLoop);
                        } while (continueLoop);
                        
                        planetFound = false;

                        for (int i = 0; i < planetList.Count; i++)
                        {
                            if (planetList[i].size >= minSize && planetList[i].size <= maxSize)
                            {
                                Console.WriteLine($"------------------\n");
                                Console.WriteLine(
                                    $"PLANET {planetList.IndexOf(planetList[i]) + 1}");

                                planetList[i].PrintPlanetName();
                                planetList[i].PrintPlanetSize();
                                planetList[i].PrintPlanetPop();
                                planetList[i].PrintPlanetType();

                                planetFound = true;
                                validChoice = true;
                            }
                        }

                        if (!planetFound)
                        {
                            Console.WriteLine(
                                "No planets that met your specifications were found. Please try again.\n");
                            validChoice = true;
                        }

                        break;
                    case 3:
                        var minPop = 0.0;
                        var maxPop = 0.0;
                        
                        do
                        {
                            Console.WriteLine("Enter the minimum population you would like to search for: ");
                            Exceptions.ParseDouble(Console.ReadLine(), out minPop, out continueLoop);
                        } while (continueLoop);
                        
                        do
                        {
                            Console.WriteLine("Enter the maximum population you would like to search for: ");
                            Exceptions.ParseDouble(Console.ReadLine(), out maxPop, out continueLoop);
                        } while (continueLoop);
                        
                        planetFound = false;

                        for (int i = 0; i < planetList.Count; i++)
                        {
                            if (planetList[i].population >= minPop && planetList[i].population <= maxPop)
                            {
                                Console.WriteLine($"------------------\n");
                                Console.WriteLine(
                                    $"PLANET {planetList.IndexOf(planetList[i]) + 1}");

                                planetList[i].PrintPlanetName();
                                planetList[i].PrintPlanetSize();
                                planetList[i].PrintPlanetPop();
                                planetList[i].PrintPlanetType();

                                planetFound = true;
                                validChoice = true;
                            }
                        }

                        if (!planetFound)
                        {
                            Console.WriteLine(
                                "No planets that met your specifications were found. Please try again.\n");
                            validChoice = true;
                        }

                        break;
                    case 4:
                        Console.WriteLine("What planet would you like to search for? Enter the type below:\n");
                        string userTypeChoice = Console.ReadLine();
                        planetFound = false;

                        for (int i = 0; i < planetList.Count; i++)
                        {
                            if (userTypeChoice == planetList[i].planetType)
                            {
                                Console.WriteLine($"------------------\n");
                                Console.WriteLine(
                                    $"PLANET {planetList.IndexOf(planetList[i]) + 1}");

                                planetList[i].PrintPlanetName();
                                planetList[i].PrintPlanetSize();
                                planetList[i].PrintPlanetPop();
                                planetList[i].PrintPlanetType();

                                planetFound = true;
                                validChoice = true;
                            }
                        }

                        if (!planetFound)
                        {
                            Console.WriteLine("The planet you are looking for could not be found. Please try again.\n");
                            validChoice = true;
                        }

                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again");
                        break;
                }
            } while (!validChoice);
        }
    }
}
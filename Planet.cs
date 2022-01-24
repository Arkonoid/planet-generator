using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet_Generator
{
    class Planet
    {
        public string name;
        public double size;
        public double population;
        public int planetCode;
        public string planetType;

        public Planet(string aName = "UNDEFINED", double aSize = 0, double aPopulation = 0.00, int aPlanetCode = 0)
        {
            name = aName;
            size = aSize;
            population = aPopulation;
            planetCode = aPlanetCode;

            switch (planetCode)
            {
                case 1:
                    planetType = "Terrestrial";
                    break;
                case 2:
                    planetType = "Ocean";
                    break;
                case 3:
                    planetType = "Jungle";
                    break;
                case 4:
                    planetType = "Lava";
                    break;
                default:
                    planetType = "UNDEFINED";
                    break;
            }
        }

        public void PrintPlanetName()
        {
            Console.Write("NAME: ");
            Console.WriteLine($"{name}");
        }

        public void PrintPlanetSize()
        {
            Console.Write("SIZE: ");
            Console.WriteLine($"{size}");
        }

        public void PrintPlanetPop()
        {
            Console.Write("POPULATION: ");
            Console.WriteLine($"{population}");
        }

        public void PrintPlanetType()
        { 

            switch (planetType)
            {
                case "Terrestrial":
                    Console.Write("TYPE: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"{planetType}\n");
                    Console.ResetColor();
                    break;
                case "Ocean":
                    Console.Write("TYPE: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{planetType}\n");
                    Console.ResetColor();
                    break;
                case "Jungle":
                    Console.Write("TYPE: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{planetType}\n");
                    Console.ResetColor();
                    break;
                case "Lava":
                    Console.Write("TYPE: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{planetType}\n");
                    Console.ResetColor();
                    break;
            }
        }

        public double GrowPop(bool message)
        {
            double oldPopulation = population;
            population += Math.Round((population * 0.15),2);

            if (message)
            {
                Console.WriteLine($"The poplulation of {this.name} has grown from {oldPopulation} to {population}!");
            }

            return population;
        }


    }
}

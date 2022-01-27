using System;

namespace Planet_Generator
{
    public class Planet
    {
        public string name;
        public double size;
        public double population;
        public string planetType;
        bool isGasGiant;

        public Planet(string aName = "UNDEFINED", double aSize = 0, double aPopulation = 0.00, int aPlanetCode = 0,
            bool aIsGasGiant = false)
        {
            {
                name = aName;
                size = aSize;
                population = aPopulation;
                isGasGiant = aIsGasGiant;

                planetType = aPlanetCode switch
                {
                    1 => "Terrestrial",
                    2 => "Ocean",
                    3 => "Jungle",
                    4 => "Lava",
                    5 => "Tundra",
                    6 => "Plains",
                    7 => "Desert",
                    8 => "Barren",
                    9 => "Arctic",
                    10 => "Forest",
                    _ => "UNDEFINED"
                };

                if (isGasGiant)
                {
                    size = Math.Round((size + 5) * 1.5, 2);
                    population = 0;
                    planetType = "Gas Giant";
                }
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
                case "Tundra":
                    Console.Write("TYPE: ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"{planetType}\n");
                    Console.ResetColor();
                    break;
                case "Plains":
                    Console.Write("TYPE: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{planetType}\n");
                    Console.ResetColor();
                    break;
                case "Desert":
                    Console.Write("TYPE: ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{planetType}\n");
                    Console.ResetColor();
                    break;
                case "Barren":
                    Console.Write("TYPE: ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"{planetType}\n");
                    Console.ResetColor();
                    break;
                case "Arctic":
                    Console.Write("TYPE: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{planetType}\n");
                    Console.ResetColor();
                    break;
                case "Forest":
                    Console.Write("TYPE: ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"{planetType}\n");
                    Console.ResetColor();
                    break;
                case "Gas Giant":
                    Console.Write("TYPE: ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{planetType}\n");
                    Console.ResetColor();
                    break;
            }
        }

        //Increases the population of the planet by 15%
        public double GrowPop(bool message)
        {
            double oldPopulation = population;
            population += Math.Round((population * 0.15), 2);

            if (message)
            {
                Console.WriteLine($"The population of {this.name} has grown from {oldPopulation} to {population}!");
            }

            return population;
        }
    }
}
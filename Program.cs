using System;

namespace Planet_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double planetSize;

            for (int i = 0; i < 10; i++)
            {
                planetSize = PlanetGen(3, 25);

                Console.WriteLine($"Planet size is {planetSize}");
            }

            Console.ReadLine();
        }

        public static int RandomNum(int min, int max)
        {
            Random rd = new Random();

            int randomNumber = rd.Next(min, max);

            return randomNumber;
        }

        public static double PlanetGen(int min, int max)
        {
            double wholeValue = RandomNum(min, max);
            double decimalValue = RandomNum(0, 100) / 100.00;

            return wholeValue + decimalValue;
        }
    }
}

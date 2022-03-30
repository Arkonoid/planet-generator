using System;

namespace Planet_Generator
{
    public class Exceptions
    {
        public static void ParseStartPlanets(string input, out int variableToSet, out bool continueLoop)
        {
            if (int.TryParse(input, out int integer))
            {
                if (integer > 0)
                {
                    variableToSet = integer;
                    continueLoop = false;
                }
                else
                {
                    Console.WriteLine("Thank you for trying to break the program. Please try again...");
                    variableToSet = 0;
                    continueLoop = true;
                }

            }
            else
            {
                Console.WriteLine("Thank you for trying to break the program. Please try again...");
                variableToSet = 0;
                continueLoop = true;
            }
        }
        public static void ParseInt(string input, out int variableToSet)
        {
            if (int.TryParse(input, out int integer))
            {
                variableToSet = integer;
            }
            else
            {
                variableToSet = 0;
            }
        }
        public static void ParseDouble(string input, out double variableToSet, out bool continueLoop)
        {
            if (double.TryParse(input, out double doub))
            {
                variableToSet = doub;
                continueLoop = false;
            }
            else
            {
                variableToSet = 0.0;
                Console.WriteLine("Error. Please enter a number...");
                continueLoop = true;
            }
        }
    }
}
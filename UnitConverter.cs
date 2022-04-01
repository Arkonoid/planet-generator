using System;
using System.Reflection;

namespace Planet_Generator
{
    public class UnitConverter
    {
        public static void Conversion(
            bool toMiles,
            bool toKilo,
            bool toLight,
            bool toAu,
            bool fromMiles,
            bool fromKilo,
            bool fromLight,
            bool fromAu)
        {
            bool continueLoop;
            double convertedUnit;

            if (toMiles)
            {
                if (fromMiles)
                {
                    Console.WriteLine("Cannot convert from Miles to Miles...");
                    Console.ReadKey();
                }
                else if (fromKilo)
                {
                    Console.Write("Enter the number of Kilometers: ");
                    do
                    {
                        Exceptions.ParseDouble(Console.ReadLine(), out convertedUnit, out continueLoop);
                    } while (continueLoop);

                    Console.WriteLine($"{convertedUnit} Kilometer(s) are equal to {FromKiloToMiles(convertedUnit)} Miles");
                    Console.ReadKey();
                }
                else if (fromLight)
                {
                    Console.Write("Enter the number of Light Years: ");
                    do
                    {
                        Exceptions.ParseDouble(Console.ReadLine(), out convertedUnit, out continueLoop);
                    } while (continueLoop);
                    
                    Console.WriteLine($"{convertedUnit} Light Year(s) are equal to {FromLightToMiles(convertedUnit)}x10^12 Miles");
                    Console.ReadKey();
                }
                else if (fromAu)
                {
                    Console.Write("Enter the number of Astronomical Units: ");
                    do
                    {
                        Exceptions.ParseDouble(Console.ReadLine(), out convertedUnit, out continueLoop);
                    } while (continueLoop);
                    
                    Console.WriteLine($"{convertedUnit} Astronomical Unit(s) are equal to {FromAuToMiles(convertedUnit)} Miles");
                    Console.ReadKey();
                }
            }
            else if (toKilo)
            {
                if (fromMiles)
                {
                    Console.Write("Enter the number of Miles: ");
                    do
                    {
                        Exceptions.ParseDouble(Console.ReadLine(), out convertedUnit, out continueLoop);
                    } while (continueLoop);

                    Console.WriteLine($"{convertedUnit} Mile(s) are equal to {FromMilesToKilo(convertedUnit)} Kilometers");
                    Console.ReadKey();
                }
                else if (fromKilo)
                {
                    Console.WriteLine("Cannot convert from Kilometers to Kilometers...");
                    Console.ReadKey();
                }
                else if (fromLight)
                {
                    Console.Write("Enter the number of Light Years: ");
                    do
                    {
                        Exceptions.ParseDouble(Console.ReadLine(), out convertedUnit, out continueLoop);
                    } while (continueLoop);
                    
                    Console.WriteLine($"{convertedUnit} Light Year(s) are equal to {FromLightToKilo(convertedUnit)}x10^12 Kilometers");
                    Console.ReadKey();
                }
                else if (fromAu)
                {
                    Console.Write("Enter the number of Astronomical Units: ");
                    do
                    {
                        Exceptions.ParseDouble(Console.ReadLine(), out convertedUnit, out continueLoop);
                    } while (continueLoop);
                    
                    Console.WriteLine($"{convertedUnit} Astronomical Unit(s) are equal to {FromAuToKilo(convertedUnit)} Kilometers");
                    Console.ReadKey();
                }
            }
            else if (toLight)
            {
                if (fromMiles)
                {
                    Console.Write("Enter the number of Miles: ");
                    do
                    {
                        Exceptions.ParseDouble(Console.ReadLine(), out convertedUnit, out continueLoop);
                    } while (continueLoop);

                    Console.WriteLine($"{convertedUnit} Mile(s) are equal to {FromMilesToLight(convertedUnit)}x10^-13 Light Years");
                    Console.ReadKey();
                }
                else if (fromKilo)
                {
                    Console.Write("Enter the number of Light Years: ");
                    do
                    {
                        Exceptions.ParseDouble(Console.ReadLine(), out convertedUnit, out continueLoop);
                    } while (continueLoop);
                    
                    Console.WriteLine($"{convertedUnit} Kilometer(s) are equal to {FromKiloToLight(convertedUnit)}x10^-13 Light Years");
                    Console.ReadKey();
                }
                else if (fromLight)
                {
                    Console.WriteLine("Cannot convert from Light Years to Light Years...");
                    Console.ReadKey();
                }
                else if (fromAu)
                {
                    Console.Write("Enter the number of Astronomical Units: ");
                    do
                    {
                        Exceptions.ParseDouble(Console.ReadLine(), out convertedUnit, out continueLoop);
                    } while (continueLoop);
                    
                    Console.WriteLine($"{convertedUnit} Astronomical Unit(s) are equal to {FromAuToLight(convertedUnit)}x10^-5 Light Years");
                    Console.ReadKey();
                }
            }
            else if (toAu)
            {
                if (fromMiles)
                {
                    Console.Write("Enter the number of Miles: ");
                    do
                    {
                        Exceptions.ParseDouble(Console.ReadLine(), out convertedUnit, out continueLoop);
                    } while (continueLoop);

                    Console.WriteLine($"{convertedUnit} Mile(s) are equal to {FromMilesToAu(convertedUnit)}x10^-8 Astronomical Units");
                    Console.ReadKey();
                }
                else if (fromKilo)
                {
                    Console.Write("Enter the number of Light Years: ");
                    do
                    {
                        Exceptions.ParseDouble(Console.ReadLine(), out convertedUnit, out continueLoop);
                    } while (continueLoop);
                    
                    Console.WriteLine($"{convertedUnit} Kilometer(s) are equal to {FromKiloToAu(convertedUnit)}x10^-9 Astronomical Units");
                    Console.ReadKey();
                }
                else if (fromLight)
                {
                    Console.Write("Enter the number of Light Years: ");
                    do
                    {
                        Exceptions.ParseDouble(Console.ReadLine(), out convertedUnit, out continueLoop);
                    } while (continueLoop);
                    
                    Console.WriteLine($"{convertedUnit} Light Year(s) are equal to {FromLightToAu(convertedUnit)} Astronomical Units");
                    Console.ReadKey();
                }
                else if (fromAu)
                {
                    
                    Console.WriteLine("Cannot convert from Astronomical Units to Astronomical Units...");
                    Console.ReadKey();
                }
            }
        }
        
        public static double FromKiloToMiles(double kilo)
        {
            return kilo * 0.62137;
        }

        public static double FromLightToMiles(double light)
        {
            return light * 5.8786254;
        }

        public static double FromAuToMiles(double au)
        {
            return au * 92955807;
        }

        public static double FromMilesToKilo(double mile)
        {
            return mile * 1.609344;
        }

        public static double FromLightToKilo(double light)
        {
            return light * 9.4607305;
        }

        public static double FromAuToKilo(double au)
        {
            return au * 149597871;
        }

        public static double FromMilesToLight(double mile)
        {
            return mile * 1.7010780;
        }
        
        public static double FromKiloToLight(double kilo)
        {
            return kilo * 1.0570008;
        }

        public static double FromAuToLight(double light)
        {
            return light * 1.5812507;
        }

        public static double FromMilesToAu(double mile)
        {
            return mile * 1.0757800;
        }

        public static double FromKiloToAu(double kilo)
        {
            return kilo * 6.6845871;
        }

        public static double FromLightToAu(double light)
        {
            return light * 63241.077;
        }
    }
    
    
}
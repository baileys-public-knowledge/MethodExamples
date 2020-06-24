using System;

namespace MethodExamples
{
    /// <summary>
    /// Example 1 Simple Method to convert to and from.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converting 20 degrees Celsius to Fahrenheit.");
            Console.WriteLine(ToFahrenheitFromCelsius(20));

            Console.WriteLine("Converting 68 degrees Fahrenheit to Celsius");
            Console.WriteLine(ToCelsiusFromFahrenheit(68));

            Console.WriteLine("Converting 100 degrees Celsius to Fahrenheit.");
            Console.WriteLine(ToFahrenheitFromCelsius(100));

            Console.WriteLine("Converting 100 degrees Fahrenheit to Celsius");
            Console.WriteLine(ToCelsiusFromFahrenheit(100));

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static double ToFahrenheitFromCelsius(double celsius) => celsius * ((double)9 / (double)5) + 32;
        private static double ToCelsiusFromFahrenheit(double fahrenheit) => (fahrenheit - 32) * ((double)5 / (double)9);
    }

    /// <summary>
    /// Example 2 using properties on a class with getters
    /// </summary>
    class Program_2
    {

        class Thermometer
        {
            public readonly double Celsius;
            public double Fahrenheit => Celsius * ((double)9 / (double)5) + 32;

            public override string ToString() => $"{Celsius}°C is {Fahrenheit}°F";

            public Thermometer(double celsius)
            {
                Celsius = celsius;
            }
        }

        static void Main(string[] args)
        {
            var thermometer = new Thermometer(20);
            Console.WriteLine(thermometer);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

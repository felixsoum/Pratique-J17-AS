using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonOutil
{
    internal class Meteo
    {
        public Meteo()
        {
            double tempEnCelsius;
            double tempEnFahrenheit;
            string? line;

            Console.WriteLine("Welcome to the Meteo tool.");
            Console.WriteLine("\n\nPlease enter the temperature in Celsius:\n\n");
            line = Console.ReadLine();
            tempEnCelsius = Convert.ToDouble(line);
            tempEnFahrenheit = (tempEnCelsius * 9 / 5) + 32;
            Console.WriteLine($"The temperature in Fahrenheit: {tempEnFahrenheit} ");
        }
    }
}

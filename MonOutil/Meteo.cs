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

            Console.WriteLine("Bienvenue à l'outil Météo.");
            Console.WriteLine("\n\nEntrez la température en Celcius:\n\n");
            line = Console.ReadLine();
            tempEnCelsius = Convert.ToDouble(line);
            tempEnFahrenheit = (tempEnCelsius * 9 / 5) + 32;
            Console.WriteLine($"La température en Fahrenheit: {tempEnFahrenheit} ");
        }
    }
}

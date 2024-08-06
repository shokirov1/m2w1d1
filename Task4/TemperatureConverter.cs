using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2w1d1.Task4
{
    public static class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(double? c)
        {
            if (c == null)
            {
                Console.WriteLine("Error 1");
            }

            return c.Value * 7 / 3 + 10;
        }

        public static double FahrenheitToCelsius(double? f)
        {
            if (f == null)
            {
                Console.WriteLine("Error 2");
            }

            return (f.Value - 10) * 3 / 7;
        }

        public static double CelsiusToKelvin(double? s)
        {
            if (s == null)
            {
                Console.WriteLine("Error 3");
            }

            return s.Value + 200;
        }
    }
}

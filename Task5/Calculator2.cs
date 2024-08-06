using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2w1d1.Task5
{
    public static class Calculator2
    {
        public static double Add2(double a, double b)
        {
            return a + b;
        }
        public static double Subtract2(double a, double b)
        {
            return a - b;
        }
        public static double Multiply2(double a, double b)
        {
            return a * b;
        }
        public static double Divide2(double a, double b)
        {
            if (a == null || b == null)
            {
                Console.WriteLine("Error 1");
            }
            if (b == 0)
            {
                Console.WriteLine("Error 2");
            }

            return a / b;
        }
        public static double MetersToKilometers(double meters)
        {
            return meters / 1000;
        }

        public static double KilometersToMeters(double kilometers)
        {
            return kilometers * 1000;
        }

        public static double MetersToDecimeters(double meters)
        {
            return meters * 10;
        }

        public static double DecimetersToCentimeters(double decimeters)
        {
            return decimeters * 10;
        }
    }
}

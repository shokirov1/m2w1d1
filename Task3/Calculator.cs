using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2w1d1.Task3
{
    public static class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            if (a == null || b == null)
            {
                Console.WriteLine("Error 1");
            }
            if (b == 0)
            {
                Console.WriteLine("Error 2");
            }

            return a/ b;
        }
    }
}

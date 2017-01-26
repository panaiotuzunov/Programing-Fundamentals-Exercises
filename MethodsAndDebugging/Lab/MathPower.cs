using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MathPowe
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = CalculatePowerOfNumber(num, power);
            Console.WriteLine(result);
        }

        private static double CalculatePowerOfNumber(double num, int power)
        {
            return Math.Pow(num, power);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ComparingFloatNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double eps = 0.000001f;

            double diff = Math.Abs(num1 - num2);

            if (diff < eps)
            {
                bool isEqual = true;
                Console.WriteLine(isEqual);
            }
            else
            {
                bool isEqual = false;
                Console.WriteLine(isEqual);
            }
        }
    }
}

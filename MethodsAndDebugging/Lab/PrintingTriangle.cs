using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
        }

        private static void PrintTriangle(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write("{0} ", column);
                }

                Console.WriteLine();
            }

            PrintTriangleLowerPart(number);
        }

        private static void PrintTriangleLowerPart(int number)
        {
            for (int row = number - 1; row >= 1; row--)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write("{0} ", column);
                }

                Console.WriteLine();
            }
        }
    }
}

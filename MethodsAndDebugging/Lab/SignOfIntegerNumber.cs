using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SignOfIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = ReadIntegerNumber();
            PrintMessage(number);
        }

        private static void PrintMessage(int number)
        {
            Console.WriteLine("The number {0} is {1}.", number, ReturnSign(number));
        }

        private static string ReturnSign(int number)
        {
            if (number > 0)
            {
                return "positive";
            }
            else if (number < 0)
            {
                return "negative";
            }
            else
            {
                return "zero";
            }
        }

        private static int ReadIntegerNumber()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}

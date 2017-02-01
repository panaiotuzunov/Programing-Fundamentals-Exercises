using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 0;
            bool isTooLarge = false;
            string numberAsString = Console.ReadLine();

            try
            {
                number = long.Parse(numberAsString);
            }
            catch (Exception)
            {
                Console.WriteLine("{0} can't fit in any type", numberAsString);
                isTooLarge = true;
            }

            bool canFitIn = false;

            if (!isTooLarge)
            {
                Console.WriteLine("{0} can fit in:", number);

                if (number >= -128 && number <= 127)
                {
                    Console.WriteLine("* sbyte");
                    canFitIn = true;
                }
                if (number >= 0 && number <= 255)
                {
                    Console.WriteLine("* byte");
                    canFitIn = true;
                }
                if (number >= -32768 && number <= 32767)
                {
                    Console.WriteLine("* short");
                    canFitIn = true;
                }
                if (number >= 0 && number <= 65535)
                {
                    Console.WriteLine("* ushort");
                    canFitIn = true;
                }
                if (number >= -2147483648 && number <= 2147483647)
                {
                    Console.WriteLine("* int");
                    canFitIn = true;
                }
                if (number >= 0 && number <= 4294967295)
                {
                    Console.WriteLine("* uint");
                    canFitIn = true;
                }
                if (number >= -9223372036854775808 && number <= 9223372036854775807)
                {
                    Console.WriteLine("* long");
                    canFitIn = true;
                }

                if (!canFitIn)
                {
                    Console.WriteLine("{0} can't fit in any type", number);
                }
            }
        }
    }
}

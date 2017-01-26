using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintSquare(num);
        }

        private static void PrintSquare(int num)
        {
            PrintBorder(num);
            PrintInnerPart(num);
            PrintBorder(num);
        }

        private static void PrintInnerPart(int num)
        {
            for (int row = 0; row < num - 2; row++)
            {
                Console.Write('-');

                for (int i = 1; i < num; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }

        private static void PrintBorder(int num)
        {
            Console.WriteLine(new string('-', 2 * num));
        }
    }
}

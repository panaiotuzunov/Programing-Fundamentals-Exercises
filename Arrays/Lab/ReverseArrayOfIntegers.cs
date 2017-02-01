using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            int[] integers = new int[numberOfElements];

            for (int element = 0; element < numberOfElements; element++)
            {
                integers[element] = int.Parse(Console.ReadLine());
            }

            integers = integers.Reverse().ToArray();

            Console.WriteLine(string.Join(" ", integers));
        }
    }
}

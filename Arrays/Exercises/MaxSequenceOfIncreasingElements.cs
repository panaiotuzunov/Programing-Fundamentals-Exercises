using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int startPosition = 0;
            int lenght = 1;
            int bestLenght = int.MinValue;
            int bestStart = int.MinValue;

            for (int element = 1; element < numbers.Length; element++)
            {
                if (numbers[element] - numbers[element - 1] >= 1)
                {
                    lenght++;
                    if (lenght > bestLenght)
                    {
                        bestLenght = lenght;
                        bestStart = startPosition;
                    }
                }
                else
                {
                    startPosition = element;
                    lenght = 1;
                }
            }

            for (int i = bestStart; i < bestStart + bestLenght; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
        }
    }
}

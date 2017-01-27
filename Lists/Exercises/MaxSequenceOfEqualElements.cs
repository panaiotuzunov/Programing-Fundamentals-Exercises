using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int start = 0;
            int length = 1;
            int bestLenght = 1;
            int bestStart = 0;

            for (int curentPos = 1; curentPos < numbers.Count; curentPos++)
            {
                if (numbers[curentPos] == numbers[curentPos - 1])
                {
                    length++;
                    if (length > bestLenght)
                    {
                        bestLenght = length;
                        bestStart = start;
                    }
                }
                else
                {
                    start = curentPos;
                    length = 1;
                }
            }

            for (int i = bestStart; i < bestStart + bestLenght; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }

        }
    }
}

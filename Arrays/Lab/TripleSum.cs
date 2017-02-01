using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
            bool foundATriple = false;

            for (int num1 = 0; num1 < numbers.Length; num1++)
            {
                for (int num2 = num1 + 1; num2 < numbers.Length; num2++)
                {
                    long sum = numbers[num1] + numbers[num2];

                    bool isATripleBool = isATriple(sum, numbers);
                    if (isATripleBool)
                    {
                        Console.WriteLine($"{numbers[num1]} + {numbers[num2]} == {sum}");
                        foundATriple = true;
                    }
                }
            }

            if (!foundATriple)
            {
                Console.WriteLine("No");
            }
        }

        private static bool isATriple(long sum, long[] numbers)
        {
            bool isATripleBool = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == sum)
                {
                    isATripleBool = true;
                }
            }

            return isATripleBool;
        }
    }
}

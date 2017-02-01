using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bestPosition = int.MinValue;

            for (int position = 0; position < numbers.Length; position++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int leftPosition = 0; leftPosition < position; leftPosition++)
                {
                    leftSum += numbers[leftPosition];
                }

                for (int rightPosition = position + 1; rightPosition < numbers.Length; rightPosition++)
                {
                    rightSum += numbers[rightPosition];
                }

                if (leftSum == rightSum)
                {
                    bestPosition = position;
                }
            }

            Console.WriteLine(bestPosition < 0 ? "no" : "{0}", bestPosition);
        }
    }
}


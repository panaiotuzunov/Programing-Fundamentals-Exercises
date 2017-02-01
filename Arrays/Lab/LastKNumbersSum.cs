using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            int sequenceElements = int.Parse(Console.ReadLine());

            long[] sequence = new long[numberOfElements];

            sequence[0] = 1;

            // обхождаме елементите на масива
            for (int curentElement = 1; curentElement < sequence.Length; curentElement++)
            {
                long sum = 0;
                int startPosition = Math.Max(0, curentElement - sequenceElements);

                for (int i = startPosition; i < curentElement; i++)
                {
                    sum += sequence[i];
                }

                sequence[curentElement] = sum;
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
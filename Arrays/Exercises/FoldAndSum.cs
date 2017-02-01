using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = numbers.Length / 4;

            int[] middle = new int[2 * k];

            for (int i = k, j = 0; i < 3 * k; i++, j++)
            {
                middle[j] = numbers[i];
            }

            int[] start = new int[k];

            for (int i = 0; i < k; i++)
            {
                start[i] = numbers[i];
            }

            int[] end = new int[k];

            for (int i = 3 * k, j = 0; i < 4 * k; i++, j++)
            {
                end[j] = numbers[i];
            }

            Array.Reverse(start);
            Array.Reverse(end);

            int[] top = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                top[i] = start[i];
            }
            for (int i = k, j = 0; i < 2 * k; i++, j++)
            {
                top[i] = end[j];
            }

            for (int i = 0; i < 2 * k; i++)
            {
                middle[i] = middle[i] + top[i];
            }

            Console.WriteLine(string.Join(" ", middle));
        }
    }
}

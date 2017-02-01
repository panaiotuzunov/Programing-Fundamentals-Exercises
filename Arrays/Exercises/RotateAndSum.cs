using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotationsCount = int.Parse(Console.ReadLine());
            int[] sumArray = new int[numbersArray.Length];

            for (int rotation = 0; rotation < rotationsCount; rotation++)
            {
                int lastElement = numbersArray[numbersArray.Length - 1];

                for (int i = 0; i < numbersArray.Length - 1; i++)
                {
                    numbersArray[numbersArray.Length - 1 - i] = numbersArray[numbersArray.Length - 2 - i];
                }

                numbersArray[0] = lastElement;

                for (int i = 0; i < numbersArray.Length; i++)
                {
                    sumArray[i] += numbersArray[i];
                }

            }

            Console.WriteLine(string.Join(" ", sumArray));

        }
    }
}

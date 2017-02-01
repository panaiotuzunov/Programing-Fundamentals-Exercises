using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int pairsCounter = 0;

            for (int firstNumber = 0; firstNumber < numbers.Length; firstNumber++)
            {
                for (int secondNumber = 0; secondNumber < numbers.Length; secondNumber++)
                {
                    if (numbers[firstNumber] - numbers[secondNumber] == difference)
                    {
                        pairsCounter++;
                    }
                }
            }

            Console.WriteLine(pairsCounter);
        }
    }
}

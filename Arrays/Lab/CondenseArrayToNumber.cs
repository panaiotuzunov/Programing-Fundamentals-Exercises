using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensedNumbersArray = numbersArray;

            while (numbersArray.Length > 1)
            {
                condensedNumbersArray = new int[numbersArray.Length - 1];

                for (int i = 0; i < numbersArray.Length - 1; i++)
                {
                    condensedNumbersArray[i] = numbersArray[i] + numbersArray[i + 1];
                }

                numbersArray = condensedNumbersArray;
            }

            Console.WriteLine(string.Join(" ", condensedNumbersArray));
        }
    }
}

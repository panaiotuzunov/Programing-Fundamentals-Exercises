using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbersAsStr = Console.ReadLine().Split();
            int sum = 0;

            for (int str = 0; str < numbersAsStr.Length; str++)
            {
                string curentStr = string.Empty;
                for (int i = numbersAsStr[str].Length - 1; i >= 0; i--)
                {
                    curentStr += numbersAsStr[str][i];
                }

                sum += int.Parse(curentStr);
            }

            Console.WriteLine(sum);
        }

    }
}

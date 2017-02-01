using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int curentNumber = 0; curentNumber < numbers.Length; curentNumber++)
            {
                Console.WriteLine("{0} => {1}", numbers[curentNumber]
                    , Math.Round(numbers[curentNumber], MidpointRounding.AwayFromZero));
            }
        }
    }
}

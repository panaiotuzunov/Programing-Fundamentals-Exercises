using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> positiveNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (number >= 0)
                {
                    positiveNumbers.Add(number);
                }
            }

            positiveNumbers.Reverse();
            string result = positiveNumbers.Count > 0 ? string.Join(" ", positiveNumbers) : "empty";
            Console.WriteLine(result);

        }
    }
}

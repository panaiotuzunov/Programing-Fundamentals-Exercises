using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> squareNumbers = new List<int>();

            foreach (var num in numbers)
            {
                bool isSquare = Math.Sqrt(num) == (int)Math.Sqrt(num);

                if (isSquare)
                {
                    squareNumbers.Add(num);
                }
            }

            squareNumbers.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}

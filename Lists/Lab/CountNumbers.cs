using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers.Sort();
            int start = 0;
            int lenght = 1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    lenght++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", numbers[start], lenght);
                    start = i + 1;
                    lenght = 1;
                }
                if (i == numbers.Count - 2)
                {
                    Console.WriteLine("{0} -> {1}", numbers[numbers.Count-1], lenght);
                }
            }

            if (numbers.Count == 1)
            {
                    Console.WriteLine("{0} -> {1}", numbers[0], lenght);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] specialAndPower = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int specialNum = specialAndPower[0];
            int power = specialAndPower[1];


            for (int curentPos = 0; curentPos < numbers.Count; curentPos++)
            {
                if (numbers[curentPos] == specialNum)
                {
                    int start = curentPos - power;
                    int end = curentPos + power;

                    if (start < 0)
                    {
                        start = 0;
                    }
                    if (end > numbers.Count - 1)
                    {
                        end = numbers.Count - 1;
                    }
                    end -= start - 1;

                    numbers.RemoveRange(start, end);

                    curentPos = 0;
                }
            }

            //Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(numbers.Sum());

        }
    }
}

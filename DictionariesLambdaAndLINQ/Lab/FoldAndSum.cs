using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = numbers.Length / 4;

            int[] lower = numbers.Skip(k).Take(2 * k).ToArray();
            int[] upper = numbers.Take(k).Reverse().ToArray().Concat(numbers.Reverse().Take(k).ToArray()).ToArray();

            Console.WriteLine(string.Join(" ", lower.Select((x, index) => x + upper[index])));
        }
    }
}

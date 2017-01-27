using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = Console.ReadLine().Split('|').ToList();
            strings.Reverse();
            List<string> result = new List<string>();

            foreach (var str in strings)
            {
                List<string> newString =
                (str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList());

                result.AddRange(newString);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
            string text = Console.ReadLine().ToLower();

            Console.WriteLine(string.Join(", ", text.Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Where(word => word.Length < 5).OrderBy(word => word).Distinct()));
        }
    }
}

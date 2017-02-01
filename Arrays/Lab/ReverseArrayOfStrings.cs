using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split();

            //    for (int element = 0; element < inputArray.Length / 2; element++) // алтернативен код
            //    {
            //        string backup = inputArray[element];
            //        inputArray[element] = inputArray[inputArray.Length - 1 - element];
            //        inputArray[inputArray.Length - 1 - element] = backup;
            //    }

            //    Console.WriteLine(string.Join(" ", inputArray));
            Array.Reverse(inputArray);

            Console.WriteLine(string.Join(" ", inputArray));
        }
    }
}

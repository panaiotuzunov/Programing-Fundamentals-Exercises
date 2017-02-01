using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();
            int leftCommonEnd = 0;
            int rightCommonEnd = 0;

            int shorterArrayLenght = Math.Min(arr1.Length, arr2.Length);

            for (int i = 0; i < shorterArrayLenght; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    leftCommonEnd++;
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < shorterArrayLenght; i++)
            {
                if (arr1[arr1.Length - 1 - i] == arr2[arr2.Length - 1 - i])
                {
                    rightCommonEnd++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(Math.Max(leftCommonEnd, rightCommonEnd));
        }
    }
}

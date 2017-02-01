using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string result = string.Empty;

            if (numbersArray.Length <= 1)
            {
                result = "{ " + string.Join(", ", numbersArray) + " }";
            }
            else if (numbersArray.Length % 2 == 0)
            {
                result = EvenArray(numbersArray);
            }
            else
            {
                result = OddArray(numbersArray);
            }

            Console.WriteLine(result);
        }

        private static string OddArray(int[] numbersArray)
        {
            int lenght = numbersArray.Length;
            int[] resultArray = new int[3];

            for (int i = lenght / 2 - 1, j = 0; i <= lenght / 2 + 1; i++, j++)
            {
                resultArray[j] = numbersArray[i];
            }

            string result = "{ " + string.Join(", ", resultArray) + " }";
            return result;
        }

        private static string EvenArray(int[] numbersArray)
        {
            int lenght = numbersArray.Length;
            int[] resultArray = new int[2];

            for (int i = lenght / 2 - 1, j = 0; i <= lenght / 2; i++, j++)
            {
                resultArray[j] = numbersArray[i];
            }

            string result = "{ " + string.Join(", ", resultArray) + " }";
            return result;
        }
    }
}

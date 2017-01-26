using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endNumber; i++)
            {

                int sum = CalculateDigitsSum(i);
                bool isNumberSpecialBool = IsNumberSpecial(sum);
                Console.WriteLine("{0} -> {1}", i, isNumberSpecialBool);
            }
        }

        private static int CalculateDigitsSum(int number)
        {
            int sum = 0;
            
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }

        private static bool IsNumberSpecial(int sum)
        {
            bool isNumberSpecial = sum == 5 || sum == 7 || sum == 11;
            return isNumberSpecial;
        }
    }
}

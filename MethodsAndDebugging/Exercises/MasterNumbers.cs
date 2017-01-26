using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());

            for (int curentNum = 1; curentNum <= endNum; curentNum++)
            {
                bool isMaster = IsPalindrome(curentNum) &&
                    isDividableBySeven(curentNum) &&
                    ContainsEvenDigit(curentNum);

                if (isMaster)
                {
                    Console.WriteLine(curentNum);
                }
            }
        }

        private static bool ContainsEvenDigit(int curentNum)
        {
            int digit;

            while (curentNum > 0)
            {
                digit = curentNum % 10;
                curentNum /= 10;
                if (digit % 2 == 0)
                    return true;
            }

            return false;
        }

        private static bool isDividableBySeven(int curentNum)
        {
            int sum = 0;

            while (curentNum > 0)
            {
                sum += curentNum % 10;
                curentNum /= 10;
            }

            return sum % 7 == 0;
        }

        private static bool IsPalindrome(int curentNum)
        {
            string numAsStr = curentNum.ToString();

            if (curentNum < 10)
            {
                return true;
            }
            else if (curentNum < 100)
            {
                return numAsStr[0] == numAsStr[1];
            }
            else
            {
                int middle = numAsStr.Length / 2;

                for (int i = 0; i < middle; i++)
                {
                    if (numAsStr[i] != numAsStr[numAsStr.Length - 1 - i])
                        return false;
                }

                return true;
            }
        }
    }
}

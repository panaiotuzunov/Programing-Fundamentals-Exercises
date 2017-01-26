using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());
            BigInteger result = CalculateFactorial(num);
            string resultStr = result.ToString();
            int trailingZeroes = CountTrailingZeroes(resultStr);
            Console.WriteLine(trailingZeroes);
        }

        private static int CountTrailingZeroes(string resultStr)
        {
            int trailingZeroes = 0;

            for (int i = resultStr.Length - 1; i >= 0; i--)
            {
                if (resultStr[i] == '0')
                {
                    trailingZeroes++;
                }
                else
                {
                    break;
                }
            }

            return trailingZeroes;
        }

        private static BigInteger CalculateFactorial(BigInteger num)
        {
            BigInteger factorial = 1;

            for (BigInteger curentNum = num; curentNum >= 1; curentNum--)
            {
                factorial *= curentNum;
            }

            return factorial;
        }
    }
}

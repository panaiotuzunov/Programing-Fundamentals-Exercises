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
            Console.WriteLine(result);
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

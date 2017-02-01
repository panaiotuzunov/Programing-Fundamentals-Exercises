using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FastPrimeCheckerRefarctor
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int curentNumber = 2; curentNumber <= endNumber; curentNumber++)
            {
                bool isPrime = true;
                for (int numbers = 2; numbers < curentNumber; numbers++)
                {
                    if (curentNumber % numbers == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{curentNumber} -> {isPrime}");
            }
        }
    }
}

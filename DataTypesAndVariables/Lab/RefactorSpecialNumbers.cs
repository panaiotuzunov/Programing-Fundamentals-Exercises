using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            bool isNumberSpecial = false;

            for (int curentNumber = 1; curentNumber <= endNumber; curentNumber++)
            {
                int curentNumberBackup = curentNumber;

                while (curentNumberBackup > 0)
                {
                    sum += curentNumberBackup % 10;
                    curentNumberBackup = curentNumberBackup / 10;
                }

                isNumberSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{curentNumber} -> {isNumberSpecial}");
                sum = 0;
            }
        }
    }
}

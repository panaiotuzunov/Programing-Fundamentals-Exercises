using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = 5;
            var num2 = 10;
            var num1Backup = num1;

            num1 = num2;
            num2 = num1Backup;

            Console.WriteLine("Before:");
            Console.WriteLine("a = 5");
            Console.WriteLine("b = 10");
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", num1);
            Console.WriteLine("b = {0}", num2);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = bool.Parse(Console.ReadLine());

            Console.WriteLine(isTrue?"Yes":"No");
        }
    }
}

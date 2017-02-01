using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startPosition = int.Parse(Console.ReadLine());
            int endPosition = int.Parse(Console.ReadLine());

            for (int curentChar = startPosition; curentChar <= endPosition; curentChar++)
            {
                Console.Write("{0} ", (char)curentChar);
            }

        }
    }
}

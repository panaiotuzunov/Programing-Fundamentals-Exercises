using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SieveOfErathostenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            bool[] numbersBool = new bool[endNumber + 1];

            numbersBool[0] = numbersBool[1] = false;
            for (int i = 2; i < numbersBool.Length; i++)
            {
                numbersBool[i] = true;
            }

            for (int i = 0; i < numbersBool.Length; i++)
            {
                if (numbersBool[i])
                {
                    for (int j = 2; j * i <= endNumber; j++)
                    {
                        numbersBool[j * i] = false;
                    }
                }
            }

            for (int i = 2; i < numbersBool.Length; i++)
            {
                if (numbersBool[i])
                {
                    Console.Write("{0} ",i);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int char1 = 'a'; char1 < 'a' + endNumber; char1++)
            {
                for (int char2 = 'a'; char2 < 'a' + endNumber; char2++)
                {
                    for (int char3 = 'a'; char3 < 'a' + endNumber; char3++)
                    {
                        Console.WriteLine(""+ "{0}{1}{2}", (char)char1, (char)char2, (char)char3);
                    }
                }
            }
        }
    }
}

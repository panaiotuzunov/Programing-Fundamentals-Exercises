using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = new char[(122 - 97) + 1];

            for (int i = 0, j = 97; i < letters.Length; i++, j++)
            {
                letters[i] = (char)j;
            }

            string word = Console.ReadLine();

            foreach (var letter in word)
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letter == letters[i])
                    {
                        Console.WriteLine("{0} -> {1}", letter, i);
                    }
                }
            }
        }
    }
}

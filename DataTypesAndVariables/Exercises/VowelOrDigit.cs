using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            bool isVowel = symbol == 65 || symbol == 69 || symbol == 73 ||
                symbol == 79 || symbol == 85 || symbol == 89 ||
                symbol == 97 || symbol == 101 || symbol == 105 ||
                symbol == 111 || symbol == 117 || symbol == 121;

            bool isDigil = symbol >= 48 && symbol <= 57;

            if (isVowel)
            {
                Console.WriteLine("vowel");
            }
            else if (isDigil)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomiseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            var random = new Random();

            for (int index = 0; index < words.Length; index++)
            {
                var curentWord = words[index];
                var randomIndex = random.Next(0, words.Length);
                var tempWord = words[randomIndex];
                words[index] = words[randomIndex];
                words[randomIndex] = curentWord;
            }

            Console.WriteLine(string.Join("\n", words));
        }
    }
}

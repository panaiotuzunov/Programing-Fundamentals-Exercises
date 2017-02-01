using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> words = new Dictionary<string, int>();
            List<string> result = new List<string>();

            foreach (var word in input)
            {
                if (words.ContainsKey(word))
                {
                    words[word]++;
                }
                else
                {
                    words[word] = 1;
                }
            }

            foreach (var pair in words)
            {
                if (pair.Value % 2 != 0)
                {
                    result.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}

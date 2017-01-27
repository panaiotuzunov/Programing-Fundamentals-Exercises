using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[]
            { ',', ';', ':', '.', '!', '(', ')', '"', '\'' , '\\', '/', '[' , ']', ' '};

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            List<string> words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var word in words)// обхождаме всички думи
            {
                int lowerCaseLetters = 0;
                int upperCaseLetters = 0;
                int mixedCaseLetters = 0;

                for (int i = 0; i < word.Length; i++)// обхождаме всички букви в думата
                {
                    if (char.IsLower(word[i]))
                    {
                        lowerCaseLetters++;
                    }
                    else if (char.IsUpper(word[i]))
                    {
                        upperCaseLetters++;
                    }
                    else
                    {
                        mixedCaseLetters++;
                    }
                }

                if (lowerCaseLetters == word.Length)
                {
                    lowerCase.Add(word);
                }
                else if (upperCaseLetters == word.Length)
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }
            lowerCase.Remove(",");

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}

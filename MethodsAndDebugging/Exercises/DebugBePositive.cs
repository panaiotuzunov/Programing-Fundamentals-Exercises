using System;
using System.Collections.Generic;

public class BePositive_broken
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());
        char[] separator = { ' ' };

        for (int seq = 0; seq < countSequences; seq++)
        {
            string[] input = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            List<int> numbers = new List<int>();
            for (int pos = 0; pos < input.Length; pos++)
            {
                numbers.Add(int.Parse(input[pos]));
            }

            bool found = false;

            for (int pos = 0; pos < numbers.Count; pos++)
            {
                int currentNum = numbers[pos];

                if (currentNum >= 0) // може да е проблем не е определено какво се прави с число 0
                {
                    if (found)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(currentNum);
                    found = true;
                }
                else
                {
                    if (pos < numbers.Count - 1)
                    {
                        currentNum += numbers[pos + 1];
                        pos++;
                    }
                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);
                        found = true;
                    }
                }

                if (pos == numbers.Count - 1 && found == true)
                {
                    Console.WriteLine();
                }
            }

            if (!found)
            {
                Console.WriteLine("(empty)");
            }
        }
    }
}
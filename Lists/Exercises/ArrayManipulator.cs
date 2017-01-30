using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] input = Console.ReadLine().Split();
            string command = input[0];

            while (command != "print")
            {
                if (command == "add")
                {
                    numbers = AddCommand(numbers, input);
                }
                else if (command == "addMany")
                {
                    numbers = AddManyCommand(numbers, input);
                }
                else if (command == "contains")
                {
                    ContainsCommand(numbers, input);
                }
                else if (command == "remove")
                {
                    numbers = RemoveCommand(numbers, input);
                }
                else if (command == "shift")
                {
                    numbers = ShiftCommand(numbers, input);
                }
                else if (command == "sumPairs")
                {
                    numbers = SumPairsCommand(numbers, input);
                }

                input = Console.ReadLine().Split();
                command = input[0];
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }

        private static List<int> SumPairsCommand(List<int> numbers, string[] input)
        {
            for (int curentNum = 0; curentNum < numbers.Count - 1; curentNum++)
            {
                numbers[curentNum] += numbers[curentNum + 1];
                numbers.RemoveAt(curentNum + 1);
            }

            return numbers;
        }

        private static List<int> ShiftCommand(List<int> numbers, string[] input)
        {
            int rotationsCount = int.Parse(input[1]);

            for (int rotation = 0; rotation < rotationsCount; rotation++)
            {
                int firstElement = numbers[0];

                for (int curentNum = 0; curentNum < numbers.Count - 1; curentNum++)
                {
                    numbers[curentNum] = numbers[curentNum + 1];
                }

                numbers[numbers.Count - 1] = firstElement;
            }

            return numbers;
        }

        private static List<int> RemoveCommand(List<int> numbers, string[] input)
        {
            int index = int.Parse(input[1]);
            numbers.RemoveAt(index);
            return numbers;
        }

        private static void ContainsCommand(List<int> numbers, string[] input)
        {
            int num = int.Parse(input[1]);
            int index = -1;

            for (int curentNum = 0; curentNum < numbers.Count; curentNum++)
            {
                if (numbers[curentNum] == num)
                {
                    index = curentNum;
                    break;
                }
            }

            Console.WriteLine(index);
        }

        private static List<int> AddManyCommand(List<int> numbers, string[] input)
        {
            int position = int.Parse(input[1]);
            int[] numsToInsert = new int[input.Length - 2];

            for (int i = 0, j = 2; i < numsToInsert.Length; i++, j++)
            {
                numsToInsert[i] = int.Parse(input[j]);
            }

            numbers.InsertRange(position, numsToInsert);

            return numbers;
        }

        private static List<int> AddCommand(List<int> numbers, string[] input)
        {
            int position = int.Parse(input[1]);
            int num = int.Parse(input[2]);
            numbers.Insert(position, num);

            return numbers;
        }
    }
}

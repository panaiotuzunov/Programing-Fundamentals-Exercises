
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (!input.Equals("END"))
            {
                string[] commandArgs = input.Split().ToArray();
                string command = commandArgs[0];

                if (command.Equals("A"))
                    AddEntry(commandArgs, phonebook);

                else if (command.Equals("S"))
                    ShowEntry(commandArgs, phonebook);

                else if (command.Equals("ListAll"))
                    ListAllEntries(phonebook);
                input = Console.ReadLine();
            }

        }

        private static void ListAllEntries(SortedDictionary<string, string> phonebook)
        {
            foreach (var entry in phonebook)
            {
                Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
            }
        }

        private static void ShowEntry(string[] commandArgs, SortedDictionary<string, string> phonebook)
        {
            string name = commandArgs[1];

            if (phonebook.ContainsKey(name))
                Console.WriteLine("{0} -> {1}", name, phonebook[name]);

            else
                Console.WriteLine("Contact {0} does not exist.", name);
        }

        private static void AddEntry(string[] commandArgs, SortedDictionary<string, string> phonebook)
        {
            string name = commandArgs[1];
            string number = commandArgs[2];
            phonebook[name] = number;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> database =
                new SortedDictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                string[] inputArgs = input.Split();
                string user = inputArgs[2].Substring(5);
                string ipAdress = inputArgs[0].Substring(3);

                if (database.ContainsKey(user))
                {
                    if (database[user].ContainsKey(ipAdress))
                    {
                        database[user][ipAdress]++;
                    }
                    else
                    {
                        database[user][ipAdress] = 1;
                    }
                }
                else
                {
                    database.Add(user, new Dictionary<string, int>());
                    database[user].Add(ipAdress, 1);
                }

                input = Console.ReadLine();
            }

            PrintUserAndIpAdresses(database);
        }

        private static void PrintUserAndIpAdresses(SortedDictionary<string, Dictionary<string, int>> database)
        {
            foreach (var item in database)
            {
                Console.WriteLine("{0}: ", item.Key);
                Dictionary<string, int> ipAdresses = item.Value;

                foreach (var pair in ipAdresses)
                {
                    string ip = pair.Key;
                    int ipOccurrence = pair.Value;

                    if (ip == ipAdresses.Keys.Last())
                    {
                        Console.Write("{0} => {1}.", pair.Key, pair.Value);
                    }
                    else
                    {
                        Console.Write("{0} => {1}, ", pair.Key, pair.Value);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

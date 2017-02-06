using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LongAgregator
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, long>> users =
                new SortedDictionary<string, SortedDictionary<string, long>>();

            int logsCount = int.Parse(Console.ReadLine());

            for (int log = 0; log < logsCount; log++)
            {
                string[] commandArgs = Console.ReadLine().Split();
                string ipAdress = commandArgs[0];
                string user = commandArgs[1];
                int curentLogDuration = int.Parse(commandArgs[2]);

                if (users.ContainsKey(user)) // проверяваме дали съществува такъв потребител
                {
                    if (users[user].ContainsKey(ipAdress)) // проверяваме дали съществува такъв IP адрес
                    {
                        users[user][ipAdress] += curentLogDuration;
                    }
                    else
                    {
                        users[user][ipAdress] = curentLogDuration;
                    }
                }
                else
                {
                    users[user] = new SortedDictionary<string, long>();
                    users[user][ipAdress] = curentLogDuration;
                }
            }

            PrintUsersDuration(users);
       }

        private static void PrintUsersDuration(SortedDictionary<string, SortedDictionary<string, long>> users)
        {
            foreach (var user in users.Keys)
            {
                Console.Write($"{user}: {GetOverallDuration(user, users)} [");
                foreach (var pair in users[user])
                {
                    string ip = pair.Key;

                    if (!ip.Equals(users[user].Keys.Last()))
                    {
                        Console.Write($"{pair.Key}, ");
                    }
                    else
                    {
                        Console.Write($"{pair.Key}");
                    }
                }
                Console.WriteLine("]");
            }
        }

        private static object GetOverallDuration(string user, SortedDictionary<string, SortedDictionary<string, long>> users)
        {
            long sum = 0;

            foreach (var pair in users[user])
            {
                sum += users[user][pair.Key];
            }

            return sum;
        }
    }
}

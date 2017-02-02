﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> emails = new Dictionary<string, string>();

            while (!input.Equals("stop"))
            {
                string email = Console.ReadLine();
                emails[input] = email;

                input = Console.ReadLine();
            }

            foreach (var resource in emails)
            {
                Console.WriteLine("{0} -> {1}", resource.Key, resource.Value);
            }
        }
    }
}

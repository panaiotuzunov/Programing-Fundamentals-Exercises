using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (!input.Equals("stop"))
            {
                int quantity = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(input))
                    resources[input] += quantity;
                else
                    resources[input] = quantity;

                input = Console.ReadLine();
            }

            foreach (var resource in resources)
            {
                Console.WriteLine("{0} -> {1}", resource.Key, resource.Value);
            }
        }
    }
}

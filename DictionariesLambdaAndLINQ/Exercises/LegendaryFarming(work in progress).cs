using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().ToLower().Split();

                for (int i = 1; i < input.Length; i += 2)
                {
                    string key = input[i];
                    int value = int.Parse(input[i - 1]);

                    bool isKeyMaterial = key == "shards" || key == "fragments" || key == "motes";

                    if (isKeyMaterial)
                    {
                        if (!keyMaterials.ContainsKey(key))
                        {
                            keyMaterials[key] += value;
                        }
                        else
                        {
                            keyMaterials[key] = value;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(key))
                        {
                            junkMaterials[key] += value;
                        }
                        else
                        {
                            junkMaterials[key] = value;
                        }
                    }
                }
            }
        }
    }
}

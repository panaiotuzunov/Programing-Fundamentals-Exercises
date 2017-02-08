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
            SortedDictionary<string, int> keyMaterials = new SortedDictionary<string, int>();
            SortedDictionary<string, int> junkMaterials = new SortedDictionary<string, int>();
            keyMaterials["shards"] = 0;
            keyMaterials["motes"] = 0;
            keyMaterials["fragments"] = 0;

            while (true)
            {
                string[] input = Console.ReadLine().ToLower().Split();
                bool ObtainedLegendary = false;

                for (int i = 1; i < input.Length; i += 2)
                {
                    string key = input[i];
                    int value = int.Parse(input[i - 1]);

                    bool isKeyMaterial = key == "shards" || key == "fragments" || key == "motes";

                    if (isKeyMaterial)
                    {
                            keyMaterials[key] += value;
                    }
                    else
                    {
                        if (junkMaterials.ContainsKey(key))
                        {
                            junkMaterials[key] += value;
                        }
                        else
                        {
                            junkMaterials[key] = value;
                        }
                    }

                    foreach (var pair in keyMaterials)
                    {
                        string material = pair.Key;
                        int quantity = pair.Value;

                        if (material == "shards" && quantity >= 250)
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            keyMaterials[material] -= 250;
                            ObtainedLegendary = true;
                            break;
                        }
                        else if (material == "fragments" && quantity >= 250)
                        {
                            Console.WriteLine("Valanyr obtained!");
                            keyMaterials[material] -= 250;
                            ObtainedLegendary = true;
                            break;
                        }
                        else if (material == "motes" && quantity >= 250)
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            keyMaterials[material] -= 250;
                            ObtainedLegendary = true;
                            break;
                        }
                    }

                    if (ObtainedLegendary)
                        break;
                }

                if (ObtainedLegendary)
                    break;
            }

            PrintKeyMaterials(keyMaterials);
            PrintJunkMaterials(junkMaterials);
        }

        private static void PrintJunkMaterials(SortedDictionary<string, int> junkMaterials)
        {
            foreach (var pair in junkMaterials)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }

        private static void PrintKeyMaterials(SortedDictionary<string, int> keyMaterials)
        {
            foreach (var pair in keyMaterials.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dragons = new Dictionary<string, SortedDictionary<string, decimal[]>>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string type = tokens[0];
                string name = tokens[1];

                var damage = 45m;

                if (!tokens[2].Equals("null"))
                    damage = decimal.Parse(tokens[2]);

                var health = 250m;

                if (!tokens[3].Equals("null"))
                    health = decimal.Parse(tokens[3]);

                var armor = 10m;

                if (!tokens[4].Equals("null"))
                    armor = decimal.Parse(tokens[4]);

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, decimal[]>();
                }

                dragons[type][name] = new decimal[] { damage, health, armor };
            }

            PrintDragonsStats(dragons);
        }

        private static void PrintDragonsStats(Dictionary<string, SortedDictionary<string, decimal[]>> dragons)
        {
            foreach (var type in dragons)
            {
                var typeName = type.Key;
                var dragonsByType = type.Value;

                var averageDamage = dragonsByType.Values.Average(a => a[0]);
                var averageHealth = dragonsByType.Values.Average(a => a[1]);
                var averageArmor = dragonsByType.Values.Average(a => a[2]);

                Console.WriteLine($"{typeName}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var dragon in dragonsByType)
                {
                    var name = dragon.Key;
                    var stats = dragon.Value;

                    var damage = stats[0];
                    var health = stats[1];
                    var armor = stats[2];

                    Console.WriteLine($"-{name} -> damage: {damage}, health: {health}, armor: {armor}");
                }
            }
        }
    }
}

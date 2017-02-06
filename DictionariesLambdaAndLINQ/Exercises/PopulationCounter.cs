using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> countries =
                new Dictionary<string, Dictionary<string, long>>();

            while (!input.Equals("report"))
            {
                string[] inputArgs = input.Split('|');
                string city = inputArgs[0];
                string country = inputArgs[1];
                long population = long.Parse(inputArgs[2]);

                if (countries.ContainsKey(country))
                {
                    if (countries[country].ContainsKey(city))
                    {
                        countries[country][city] += population;
                    }
                    else
                    {
                        countries[country][city] = population;
                    }
                }
                else
                {
                    countries.Add(country, new Dictionary<string, long>());
                    countries[country][city] = population;
                }

                input = Console.ReadLine();
            }


            PrintCountriesCitiesAndPopulation(countries);
        }

        private static void PrintCountriesCitiesAndPopulation(Dictionary<string, Dictionary<string, long>> countries)
        {
            foreach (var countryAndTownPair in countries.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                string country = countryAndTownPair.Key;
                var townAndPopulation = countryAndTownPair.Value;
                long population = townAndPopulation.Values.Sum();

                Console.WriteLine($"{country} (total population: {population})");

                foreach (var townAndPopulationPair in townAndPopulation.OrderByDescending(x => x.Value))
                {
                    string city = townAndPopulationPair.Key;
                    long cityPopulation = townAndPopulationPair.Value;

                    Console.WriteLine($"=>{city}: {cityPopulation}");
                }
            }
        }
    }
}

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

            foreach (var country in countries)
            {
                Dictionary<string, long> cities = country.Value;

                long population = GetCountryPopulation(cities);
                Console.WriteLine($"{country.Key} (total population: {population})");
                foreach (var city in cities)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }

        private static long GetCountryPopulation(Dictionary<string, long> cities)
        {
            long sum = 0;
            foreach (var city in cities)
            {
                sum += city.Value;
            }

            return sum;
        }
    }
}

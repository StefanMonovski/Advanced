using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continentsData = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < numberInput; i++)
            {
                List<string> inputData = Console.ReadLine().Split().ToList();
                string continent = inputData[0];
                string country = inputData[1];
                string city = inputData[2];
                if (continentsData.ContainsKey(continent))
                {
                    if (continentsData[continent].ContainsKey(country))
                    {
                        continentsData[continent][country].Add(city);
                    }
                    else
                    {
                        continentsData[continent].Add(country, new List<string>());
                        continentsData[continent][country].Add(city);
                    }
                }
                else
                {
                    continentsData.Add(continent, new Dictionary<string, List<string>>());
                    continentsData[continent].Add(country, new List<string>());
                    continentsData[continent][country].Add(city);
                }
            }
            foreach (var item in continentsData)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var country in item.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}

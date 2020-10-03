using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < numberInput; i++)
            {
                List<string> inputData = Console.ReadLine().Split(" -> ").ToList();
                string color = inputData[0];
                List<string> clothes = inputData[1].Split(",").ToList();
                if (wardrobe.ContainsKey(color))
                {
                    foreach (string item in clothes)
                    {
                        if (wardrobe[color].ContainsKey(item))
                        {
                            wardrobe[color][item]++;
                        }
                        else
                        {
                            wardrobe[color].Add(item, 1);
                        }
                    }
                }
                else
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                    foreach (string item in clothes)
                    { 
                        if (wardrobe[color].ContainsKey(item))
                        {
                            wardrobe[color][item]++;
                        }
                        else
                        {
                            wardrobe[color].Add(item, 1);
                        }
                    }
                }
            }
            string[] searchClothing = Console.ReadLine().Split().ToArray();
            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var clothing in wardrobe[color.Key])
                {
                    if (color.Key == searchClothing[0] && clothing.Key == searchClothing[1])
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                    }
                }
            }
        }
    }
}

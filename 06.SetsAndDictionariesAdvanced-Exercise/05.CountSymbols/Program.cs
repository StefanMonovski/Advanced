using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] textChars = Console.ReadLine().ToCharArray();
            Dictionary<char, int> countChars = new Dictionary<char, int>();
            for (int i = 0; i < textChars.Length; i++)
            {
                if (countChars.ContainsKey(textChars[i]))
                {
                    countChars[textChars[i]]++;
                }
                else
                {
                    countChars.Add(textChars[i], 1);
                }
            }
            var orderedCountChars = countChars.OrderBy(x => x.Key);
            foreach (var item in orderedCountChars)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}

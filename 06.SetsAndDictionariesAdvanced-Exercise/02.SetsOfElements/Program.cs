using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] setLengths = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            HashSet<int> uniqueNumbers = new HashSet<int>();
            for (int i = 0; i < setLengths[0]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }
            for (int i = 0; i < setLengths[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSet.Add(number);
            }
            foreach (int item in firstSet)
            {
                if (secondSet.Contains(item))
                {
                    uniqueNumbers.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", uniqueNumbers));
        }
    }
}

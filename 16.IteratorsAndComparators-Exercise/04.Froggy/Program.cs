using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            Lake lake = new Lake(input);
            List<int> frogStonePath = new List<int>();
            foreach (int item in lake)
            {
                frogStonePath.Add(item);
            }
            Console.WriteLine(string.Join(", ", frogStonePath));
        }
    }
}

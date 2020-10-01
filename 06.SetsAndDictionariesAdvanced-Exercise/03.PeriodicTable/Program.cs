using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            SortedSet<string> uniqueElements = new SortedSet<string>();
            for (int i = 0; i < numberInput; i++)
            {
                List<string> inputData = Console.ReadLine().Split().ToList();
                foreach (string item in inputData)
                {
                    uniqueElements.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", uniqueElements));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            string command = Console.ReadLine();
            List<int> numbers = new List<int>();
            for (int i = bounds[0]; i <= bounds[1]; i++)
            {
                numbers.Add(i);
            }
            Predicate<string> getParity = x => x == "even";
            bool even = getParity(command);
            if (even)
            {
                numbers = numbers.Where(x => Math.Abs(x % 2) == 0).ToList();
            }
            else if (!even)
            {
                numbers = numbers.Where(x => Math.Abs(x % 2) == 1).ToList();
            }
            Action<List<int>> printNumbers = x => Console.WriteLine(string.Join(" ", x));
            printNumbers(numbers);
        }
    }
}

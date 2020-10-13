using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxAcceptableLength = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Func<string[], int, List<string>> filterNamesByLength = (x, y) => x.Where(n => n.Length <= y).ToList();
            List<string> filteredNamesByLength = filterNamesByLength(names, maxAcceptableLength);
            Action<string> printName = x => Console.WriteLine(x);
            foreach (string item in filteredNamesByLength)
            {
                printName(item);
            }
        }
    }
}

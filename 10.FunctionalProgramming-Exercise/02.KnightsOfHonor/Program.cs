using System;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Action<string> printKnight = x => Console.WriteLine($"Sir {x}");
            foreach (string item in names)
            {
                printKnight(item);
            }
        }
    }
}

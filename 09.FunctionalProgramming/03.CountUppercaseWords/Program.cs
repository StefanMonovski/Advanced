using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> checkUppercase = x => x[0] == x.ToUpper()[0];
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(checkUppercase).ToArray();
            foreach (string item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}

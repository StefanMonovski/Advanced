using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            HashSet<string> uniqueUsernames = new HashSet<string>();
            for (int i = 0; i < numberInput; i++)
            {
                string input = Console.ReadLine();
                uniqueUsernames.Add(input);
            }
            foreach (string item in uniqueUsernames)
            {
                Console.WriteLine(item);
            }
        }
    }
}

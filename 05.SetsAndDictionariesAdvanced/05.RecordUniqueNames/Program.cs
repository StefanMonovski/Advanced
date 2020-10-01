using System;
using System.Collections.Generic;

namespace _05.RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            HashSet<string> uniqueNames = new HashSet<string>();
            for (int i = 0; i < numberInput; i++)
            {
                string name = Console.ReadLine();
                uniqueNames.Add(name);
            }
            foreach (string item in uniqueNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}

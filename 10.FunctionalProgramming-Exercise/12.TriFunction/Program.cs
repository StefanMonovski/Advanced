using System;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthNeeded = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            string name = ReturnNameCondition(names, CompareNameLength, lengthNeeded);
            Console.WriteLine(name);
        }

        static string ReturnNameCondition(string[] names, Func<string, int, bool> compareNameLength, int lengthNeeded)
        {
            foreach (string item in names)
            {
                if (compareNameLength(item, lengthNeeded))
                {
                    return item;
                }
            }
            return null;
        }

        static bool CompareNameLength(string name, int lengthNeeded)
        {
            int charSum = 0;
            foreach (char item in name)
            {
                charSum += item;
            }
            if (charSum >= lengthNeeded)
            {
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Linq;

namespace _08.CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Array.Sort(numbers, CustomComparator);
            Action<int[]> printNumbers = x => Console.WriteLine(string.Join(" ", x));
            printNumbers(numbers);
        }

        static int CustomComparator(int x, int y)
        {
            if (x % 2 == 0 && y % 2 == 0)
            {
                return x.CompareTo(y);
            }
            if (Math.Abs(x % 2) == 1 && Math.Abs(y % 2) == 1)
            {
                return x.CompareTo(y);
            }
            if (x % 2 == 0 && Math.Abs(y % 2) == 1)
            {
                return -1;
            }
            if (Math.Abs(x % 2) == 1 && y % 2 == 0)
            {
                return 1;
            }
            return 0;
        }
    }
}

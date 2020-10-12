using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Func<int[], int> getMin = GetMin;
            int minNumber = getMin(numbers);
            Action<int> printMinNumber = x => Console.WriteLine(x);
            printMinNumber(minNumber);
        }

        static int GetMin(int[] numbers)
        {
            int minValue = int.MaxValue;
            foreach (int item in numbers)
            {
                if (item < minValue)
                {
                    minValue = item;
                }
            }
            return minValue;
        }
    }
}

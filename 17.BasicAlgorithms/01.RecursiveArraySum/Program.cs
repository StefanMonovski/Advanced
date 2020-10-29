using System;
using System.Linq;

namespace _01.RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = RecursiveSum(input, 0);
            Console.WriteLine(sum);
        }

        private static int RecursiveSum(int[] input, int index)
        {
            if (index == input.Length)
            {
                return 0;
            }
            int currentSum = input[index] + RecursiveSum(input, index + 1);
            return currentSum;
        }
    }
}

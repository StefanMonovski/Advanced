using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            Queue<int> numbers = new Queue<int>(input.Select(int.Parse));
            int totalNumbers = numbers.Count;
            for (int i = 0; i < totalNumbers; i++)
            {
                int number = numbers.Dequeue();
                if (number % 2 == 0)
                {
                    numbers.Enqueue(number);
                }
            }
            int[] evenNumbers = numbers.ToArray();
            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}

using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            Dictionary<int, int> inputNumbers = new Dictionary<int, int>();
            for (int i = 0; i < numberInput; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (inputNumbers.ContainsKey(input))
                {
                    inputNumbers[input]++;
                }
                else
                {
                    inputNumbers.Add(input, 1);
                }
            }
            foreach (var item in inputNumbers)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                    break;
                }
            }
        }
    }
}

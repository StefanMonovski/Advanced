using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberQueries = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            for (int i = 0; i < numberQueries; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                int query = int.Parse(input[0]);
                if (query == 1)
                {
                    int number = int.Parse(input[1]);
                    numbers.Push(number);
                }
                else if (query == 2)
                {
                    numbers.Pop();
                }
                else if (query == 3 && numbers.Count != 0)
                {
                    int[] numbersArray = numbers.ToArray();
                    Console.WriteLine(numbersArray.Max());
                }
                else if (query == 4 && numbers.Count != 0)
                {
                    int[] numbersArray = numbers.ToArray();
                    Console.WriteLine(numbersArray.Min());
                }
            }
            int[] numbersOutput = numbers.ToArray();
            Console.WriteLine(string.Join(", ", numbersOutput));
        }
    }
}

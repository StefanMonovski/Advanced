using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputData = Console.ReadLine().Split().ToList();
            List<string> inputNumbers = Console.ReadLine().Split().ToList();
            List<int> numbers = inputNumbers.Select(int.Parse).ToList();
            int numbersPush = int.Parse(inputData[0]);
            int numbersPop = int.Parse(inputData[1]);
            int specialNumber = int.Parse(inputData[2]);
            Stack<int> numbersStack = new Stack<int>();
            for (int i = 0; i < numbersPush; i++)
            {
                numbersStack.Push(numbers[i]);
            }
            for (int i = 0; i < numbersPop; i++)
            {
                numbersStack.Pop();
            }
            if (numbersStack.Count == 0)
            {
                Console.WriteLine(numbersStack.Count);
            }
            else
            {
                int[] numbersArray = numbersStack.ToArray();
                if (numbersArray.Contains(specialNumber))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(numbersArray.Min());
                }
            }
        }
    }
}

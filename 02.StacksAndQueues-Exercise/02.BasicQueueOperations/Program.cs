using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputData = Console.ReadLine().Split().ToList();
            List<string> inputNumbers = Console.ReadLine().Split().ToList();
            List<int> numbers = inputNumbers.Select(int.Parse).ToList();
            int numbersEnqueue = int.Parse(inputData[0]);
            int numbersDequeue = int.Parse(inputData[1]);
            int specialNumber = int.Parse(inputData[2]);
            Queue<int> numbersQueue = new Queue<int>();
            for (int i = 0; i < numbersEnqueue; i++)
            {
                numbersQueue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < numbersDequeue; i++)
            {
                numbersQueue.Dequeue();
            }
            if (numbersQueue.Count == 0)
            {
                Console.WriteLine(numbersQueue.Count);
            }
            else
            {
                int[] numbersArray = numbersQueue.ToArray();
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

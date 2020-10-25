using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputTasks = Console.ReadLine().Split(", ").ToList();
            List<string> inputThreads = Console.ReadLine().Split(" ").ToList();
            Stack<int> tasks = new Stack<int>(inputTasks.Select(int.Parse));
            Queue<int> threads = new Queue<int>(inputThreads.Select(int.Parse));
            int killTaskValue = int.Parse(Console.ReadLine());
            int killerThreadValue = 0;
            bool taskKilled = false;
            while (taskKilled == false)
            {
                int currentTask = tasks.Peek();
                int currentThread = threads.Peek();
                if (currentTask == killTaskValue)
                {
                    killerThreadValue = currentThread;
                    taskKilled = true;
                    break;
                }
                if (currentThread >= currentTask)
                {      
                    tasks.Pop();
                    threads.Dequeue();
                }
                else if (currentThread < currentTask)
                {
                    threads.Dequeue();
                }
            }
            Console.WriteLine($"Thread with value {killerThreadValue} killed task {killTaskValue}");
            Console.WriteLine(string.Join(" ", threads.ToArray()));
        }
    }
}

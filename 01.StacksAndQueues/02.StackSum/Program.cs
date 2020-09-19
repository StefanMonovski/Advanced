using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            Stack<int> numbers = new Stack<int>(input.Select(int.Parse));
            string command = ""; 
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                List<string> commandData = command.Split(' ').ToList();
                if (commandData[0] == "add")
                {
                    numbers.Push(int.Parse(commandData[1]));
                    numbers.Push(int.Parse(commandData[2]));
                }
                else if (commandData[0] == "remove" && int.Parse(commandData[1]) <= numbers.Count)
                {
                    for (int i = 0; i < int.Parse(commandData[1]); i++)
                    {
                        numbers.Pop();
                    }
                }
            }
            int sum = 0;
            foreach (int item in numbers)
            {
                sum += item;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

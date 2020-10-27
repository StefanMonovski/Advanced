using System;
using System.Linq;

namespace _03.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pushInput = Console.ReadLine().Substring(5).Split(", ");
            Stack<string> stack = new Stack<string>(pushInput.ToList());
            string command = "";
            while ((command = Console.ReadLine()) != "END")
            {
                if (command.Contains("Push"))
                {
                    stack.Push(command.Substring(5).Split());
                }
                else if (command == "Pop")
                {
                    stack.Pop();
                }
            }
            for (int i = 0; i < 2; i++)
            {
                foreach (string item in stack)
                {
                    Console.WriteLine(item);
                }
            }          
        }
    }
}

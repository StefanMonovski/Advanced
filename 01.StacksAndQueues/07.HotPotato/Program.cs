using System;
using System.Collections.Generic;

namespace _07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> children = new Queue<string>(Console.ReadLine().Split());
            int tosses = int.Parse(Console.ReadLine());
            int counter = 1;
            while (children.Count != 1)
            {
                string currentChild = children.Dequeue();
                if (counter == tosses)
                {
                    Console.WriteLine($"Removed {currentChild}");
                    counter = 0;
                }
                else
                {
                    children.Enqueue(currentChild);
                }
                counter++;
            }
            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}

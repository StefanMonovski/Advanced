using System;
using System.Collections.Generic;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> clients = new Queue<string>();
            string input = "";
            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    while (clients.Count != 0)
                    {
                        Console.WriteLine(clients.Dequeue());
                    }
                }
                else
                {
                    clients.Enqueue(input);
                }
            }
            Console.WriteLine($"{clients.Count} people remaining.");
        }
    }
}

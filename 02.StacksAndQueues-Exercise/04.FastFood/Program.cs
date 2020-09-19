using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            List<string> input = Console.ReadLine().Split().ToList();
            Queue<int> orders = new Queue<int>(input.Select(int.Parse));
            int[] ordersArray = orders.ToArray();
            Console.WriteLine(ordersArray.Max());
            int totalOrders = orders.Count;
            for (int i = 0; i < totalOrders; i++)
            {
                int currentOrder = orders.Peek();
                if (quantityFood >= currentOrder)
                {
                    quantityFood -= currentOrder;
                    orders.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (orders.Count != 0)
            {
                Console.Write("Orders left: ");
                while (orders.Count != 0)
                {
                    Console.Write($"{orders.Dequeue()} ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}

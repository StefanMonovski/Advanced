using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputCupsCapacity = Console.ReadLine().Split().ToList();
            Queue<int> cups = new Queue<int>(inputCupsCapacity.Select(int.Parse));
            List<string> inputBottlesCapacity = Console.ReadLine().Split().ToList();
            Stack<int> bottles = new Stack<int>(inputBottlesCapacity.Select(int.Parse));
            int wastedLiters = 0;
            while (cups.Count != 0 && bottles.Count != 0)
            {
                int currentCup = cups.Peek();
                while (currentCup > 0)
                {
                    int currentBottle = bottles.Pop();
                    if (currentBottle >= currentCup)
                    {
                        wastedLiters += currentBottle - currentCup;
                        currentCup -= currentBottle;
                        cups.Dequeue();
                    }
                    else if (currentBottle < currentCup)
                    {
                        currentCup -= currentBottle;
                    }
                }
            }
            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else if (bottles.Count == 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            Console.WriteLine($"Wasted liters of water: {wastedLiters}");
        }
    }
}

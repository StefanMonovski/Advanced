using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            Stack<int> clothesValues = new Stack<int>(input.Select(int.Parse));
            int rackCapacity = int.Parse(Console.ReadLine());
            int currentRack = 0;
            int totalRacks = 0;
            while (clothesValues.Count != 0)
            {
                int currentValue = clothesValues.Pop();
                if (rackCapacity > currentRack + currentValue)
                {
                    currentRack += currentValue;
                }
                else if (rackCapacity == currentRack + currentValue)
                {
                    currentRack = 0;
                    totalRacks++;
                }
                else if (rackCapacity < currentRack + currentValue)
                {
                    currentRack = currentValue;
                    totalRacks++;
                }
            }
            if (currentRack != 0)
            {
                totalRacks++;
            }
            Console.WriteLine(totalRacks);
        }
    }
}

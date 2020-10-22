using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.GenericSwapMethodString
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            List<Box<string>> boxes = new List<Box<string>>();
            for (int i = 0; i < numberInput; i++)
            {
                boxes.Add(new Box<string>(Console.ReadLine()));
            }
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Swap(boxes, indexes[0], indexes[1]);
            foreach (Box<string> item in boxes)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void Swap<T>(List<Box<T>> boxes, int firstIndex, int secondIndex)
        {
            Box<T> tempBox = boxes[firstIndex];
            boxes[firstIndex] = boxes[secondIndex];
            boxes[secondIndex] = tempBox;
        }
    }
}

using System;
using System.Collections.Generic;

namespace _06.GenericCountMethodDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            List<Box<double>> boxes = new List<Box<double>>();
            for (int i = 0; i < numberInput; i++)
            {
                boxes.Add(new Box<double>(double.Parse(Console.ReadLine())));
            }
            Box<double> compareValue = new Box<double>(double.Parse(Console.ReadLine()));
            Console.WriteLine(Compare(boxes, compareValue));
        }

        static int Compare<T>(List<Box<T>> boxes, Box<T> compareValue) where T : IComparable<T>
        {
            int count = 0;
            foreach (Box<T> item in boxes)
            {
                if (item.CompareTo(compareValue.GenericBox) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

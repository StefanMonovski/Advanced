using System;
using System.Collections.Generic;

namespace _05.GenericCountMethodString
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
            Box<string> compareValue = new Box<string>(Console.ReadLine());
            Console.WriteLine(Compare(boxes, compareValue));
        }

        static int Compare<T>(List<Box<T>> boxes, Box<T> compareValue) where T: IComparable<T>
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

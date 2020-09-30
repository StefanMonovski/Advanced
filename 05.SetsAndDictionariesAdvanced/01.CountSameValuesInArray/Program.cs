using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputArray = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> countSameValues = new Dictionary<double, int>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (countSameValues.ContainsKey(inputArray[i]))
                {
                    countSameValues[inputArray[i]]++;
                }
                else
                {
                    countSameValues.Add(inputArray[i], 1);
                }
            }
            foreach (var item in countSameValues)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
